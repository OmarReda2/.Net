using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications
{
    // ... 5.4.10 coming from Repository\GenericRepository.cs
    // - to make the query generic we need this configuration:
    //   a. criteria: for the where conditions, it will equal null when we get all product
    //                and a value (lambda expression) when get the id of product
    //   b. list of Includes: which indicate for the include(), what and how many entity we will include
    // 5.4.10 so we will create a signature(prop) of these config(critiria, list of )
    public interface ISpecification<T>                                
    {
        // - the criteria is "Where" condition in query which represent
        //   in lambda expression (like p => p.id == id), so it will be represented as a func and this func
        //   takes a "T" which is product and will return bool (like p => p.id == 1/2/3/etc...) if the id was exist
        public Expression<Func<T, bool>> Criteria { get; set; }

        // - to make an include we make it in lambda expression (like p => p.productBrand)  
        // - so we will represent it also in Expression(func), and this expression takes a
        //   T and return an object(like productBrand, productType)
        // - as the "includes" includes a list of the previous func so it will be a list of func
        public List<Expression<Func<T, object>>> Includes { get; set; }
    }

    // 5.4.11 we will make a Specifications/baseSpecification
    //        as it will implement this interface(ISpecification)
    //- we will make it as every entity will includes its entity, like the product will includes the productBrand and Type
    //  ,the employee will include the departement if it exist and so on
}
