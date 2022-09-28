using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications
{
    // ... 5.4.11 coming from ISpecification
    // 5.4.12 imp the interface
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; } 
            = new List<Expression<Func<T, object>>>(); // intialize the list

        // 5.4.13 create a ctor that will take criteria
        public BaseSpecification(Expression<Func<T, bool>> Criteria)
        {
            this.Criteria = Criteria;
        }

        // 5.4.14 
        // - as the "includes" includes a list of expressions(func) "Func<T, object>" 
        //   so we will make a function to add the expressions
        // - and intailize the list "Includes" 
        public void AddIncludes(Expression<Func<T, object>> Include)
        {
            Includes.Add(Include);
        }

        // 5.4.15 create SpecificationEvaluator.cs
        // 5.4.15 go to SpecificationEvaluator.cs
        // as will need to make a fucntion to create the query 

        // 5.4.25 coming from ProductWithTypeAndBrandSpecifaication
        // make the empty ctor as if we did not make the "ProductWithTypeAndBrandSpecifaication" will chain ctor with criteria
        public BaseSpecification()
        {

        }

    }
}
