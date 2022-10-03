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

        //... p9.1 coming from TextFile.cs
        // to order by we use lymbda expression like P = P.Price
        //p9.2 so we will add OrderBy and OrderByDescending props that takes Expression
        public Expression<Func<T, object>> OrderBy { get; set; }
        public Expression<Func<T, object>> OrderByDescending { get; set; }
        //p9.3 go to BaseSpecifcation and imp the prop
    }
}

    
