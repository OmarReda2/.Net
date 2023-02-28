using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{
    
    public class SpecificationsEvaluator<TEntity> where TEntity:BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
        
        {
            var query = inputQuery; // _StoreContexct.Set<Product>
            if (spec.Criteria != null)
                query = query.Where(spec.Criteria);  // => _StoreContexct.Set <Product>.Where(P => P.id == id)


            // ...p9.6 coming from BaseSpecifcation
            // p9.7 add the orderBy to query
            if (spec.OrderBy != null)
                query = query.OrderBy(spec.OrderBy); //=> _StoreContexct.Set<Product>.OrderBy(P => P.Price)

            if (spec.OrderByDescending != null)
                query = query.OrderByDescending(spec.OrderByDescending); // => _StoreContexct.Set<Product>.OrderByDescending(P => P.Price)
            // p9.8 go to ProductController continue the config of sorting....


            query = spec.Includes.Aggregate(query, (currentQuery, include) => currentQuery.Include(include));
            // => _StoreContexct.Set<Product>.Include(P => P.ProductBrand).Include(P => P.ProductType)



            return query;
        }

    }
}
