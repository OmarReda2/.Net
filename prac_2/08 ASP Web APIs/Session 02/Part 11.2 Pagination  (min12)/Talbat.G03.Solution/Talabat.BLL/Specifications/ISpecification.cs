using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications
{

    public interface ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; }
        public Expression<Func<T, object>> OrderBy { get; set; }
        public Expression<Func<T, object>> OrderByDescending { get; set; }

        //p12.2 coming from Products/ProductSpecParam
        //p12.3 add Take, Skip and IsPaginationEnabled it was take in linq an int
        public int Take { get; set; } 
        public int Skip { get; set; }
        public bool IsPaginationEnabled { get; set; }
    }
}

    
