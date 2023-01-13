using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{

    public class SpecificationsEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)

        {
            var query = inputQuery; // _StoreContexct.Set<Product>
            if (spec.Criteria != null)
                query = query.Where(spec.Criteria);  // => _StoreContexct.Set <Product>.Where(P => P.id == id)

            if (spec.OrderBy != null)
                query = query.OrderBy(spec.OrderBy); //=> _StoreContexct.Set<Product>.OrderBy(P => P.Price)

            if (spec.OrderByDescending != null)
                query = query.OrderByDescending(spec.OrderByDescending); // => _StoreContexct.Set<Product>.OrderByDescending(P => P.Price)

            // ... 12.8 coming from ProductWithTypeAndBrandSpecifaication
            // 12.9 add Skip and take to query
            if (spec.IsPaginationEnabled)
                query = query.Skip(spec.Skip).Take(spec.Take);
            //12.10 make Helpers/Pagination.cs as we want to make the response
            //      have PageIndex, PageSize, Count and Data
            //12.10 go to Helpers/Pagination.cs


            query = spec.Includes.Aggregate(query, (currentQuery, include) => currentQuery.Include(include));
            // => _StoreContexct.Set<Product>.Include(P => P.ProductBrand).Include(P => P.ProductType)



            return query;
        }

    }
}
