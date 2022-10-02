using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{
    // ... 5.4.15 coming from BaseSpecifacation
    
    // 5.4.16 make the function that make the query
    public class SpecificationsEvaluator<TEntity> where TEntity:BaseEntity
    {
        // - the type of query is IQuerable,
        // - any thing that get query from database its type will be IQueryable
        //   and it will query from entities product, productBrand, producType
        // - so the type will be IQuerable<TEntity> (where TEntity:BaseEntity)
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
        // - it will take 2 parameters:
        //   a. start query/input query: _context.set<...>
        //   - as we have build criteria(where condition) and the list of Includes    
        //     we need to build the start query, so it will be : start query.criteria(if not null).list of Includes 
        //   b. ISpecification (criteria and list of Includes)
        {
            var query = inputQuery;
            if (spec.Criteria != null)
                query = query.Where(spec.Criteria); // _context.Set<Product>.Where(P => P.id)


            // _context.Set<Product>
            query = spec.Includes.Aggregate(query, (currentQuery, include) => currentQuery.Include(include));
            // - aggregate : add to the query variable(_context.Set<Product>), currentQuery and Include which currentQuery.Include(include) 
            // _context.Set<Product>.Include(P => P.ProductType).Include(P => P.ProductBrand)


            return query;
        }

        // - we have finish our design pattern(specification) now we want to apply it
        // 5.4.17 go to GenericRepository ...
    }
}
