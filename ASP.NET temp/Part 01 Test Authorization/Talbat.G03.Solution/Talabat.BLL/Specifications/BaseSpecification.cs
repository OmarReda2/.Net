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
        public List<Expression<Func<T, object>>> Includes { get; set; } //  P => P.ProductBrand 
            = new List<Expression<Func<T, object>>>(); // intialize the list



        public Expression<Func<T, object>> OrderBy { get; set; } // P => P.Price
        public Expression<Func<T, object>> OrderByDescending { get; set; }// P => P.Price


        // ... p12.3 Coming from ISpecifcation
        // 12.4 imp the interface
        public int Take { get; set; }
        public int Skip { get; set; }
        public bool IsPaginationEnabled { get; set; }






        // // // this function is only to set the value of the specification (props) // // //

        // 12.5 add ApplyPagination()
        public void ApplyPagination(int skip, int take)
        {
            IsPaginationEnabled = true;
            Skip = skip;
            Take = take;
        }
        // 12.6 go to ProductWithTypeAndBrandSpecifaication (ProductSpecification) ...
        public void AddOrderBy(Expression<Func<T, object>> orderBy)
        {
            OrderBy = orderBy;
        }
        public void AddOrderByDescending(Expression<Func<T, object>> orderByDescending)
        {
            OrderByDescending = orderByDescending;
        }
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
