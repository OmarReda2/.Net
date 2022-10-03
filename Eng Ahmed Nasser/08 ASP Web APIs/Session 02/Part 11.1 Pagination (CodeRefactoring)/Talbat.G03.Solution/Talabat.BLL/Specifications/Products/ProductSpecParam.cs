using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.BLL.Specifications.Products
{
    // ... p11.3 coming from ProductController
    // p11.4 add the prop of that represent the parameters
    public class ProductSpecParam
    {
        public string Sort { get; set; }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
    }
    //p11.4 return to ProductController to add the an object as a param...
}
