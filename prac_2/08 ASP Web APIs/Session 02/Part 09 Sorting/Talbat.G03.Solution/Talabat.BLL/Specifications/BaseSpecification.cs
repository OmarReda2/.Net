using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; set; } //P => P.id == id
        public List<Expression<Func<T, object>>> Includes { get; set; }  
            = new List<Expression<Func<T, object>>>(); // intialize the list


        // ... p9.3 coming from ISpecification
        // p9.4 imp the interface
        public Expression<Func<T, object>> OrderBy { get; set; } // P => P.Price
        public Expression<Func<T, object>> OrderByDescending { get; set; }






        //p9.5 add function that set the OrderBy & OrderByDescending
        public void AddOrderBy(Expression<Func<T, object>> orderBy)
        {
            OrderBy = orderBy;
        }
        public void AddOrderByDescending(Expression<Func<T, object>> orderByDescending)
        {
            OrderByDescending = orderByDescending;
        }
        //p9.6 go to SpecifcationEvaluator that build the query and add the OrderBy...


        public void AddIncludes(Expression<Func<T, object>> Include)
        {
            Includes.Add(Include);
        }

        




        public BaseSpecification(Expression<Func<T, bool>> Criteria)
        {
            this.Criteria = Criteria;
        }

        public BaseSpecification()
        {

        }

    }
}
