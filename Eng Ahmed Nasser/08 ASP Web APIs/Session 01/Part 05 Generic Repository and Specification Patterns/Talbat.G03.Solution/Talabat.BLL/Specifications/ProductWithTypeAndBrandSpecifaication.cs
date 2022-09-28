using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{
    //... 5.4.24 coming from productController
    public class ProductWithTypeAndBrandSpecifaication : BaseSpecification<Product>
    {
    // 5.4.25 make an empty ctor in BaseSpecifcation ...
    // - as it BaseSpecification has an empty ctor so this class will chain from it (wouldn't need any additional parameters)
    // - we make the ctor with cretiria when we use the product with id
    // - but know we have made ctor without criteria as we want to get all the product
    //   so the criteria would be null
        public ProductWithTypeAndBrandSpecifaication()
        {
            AddIncludes(P => P.ProductBrand);
            AddIncludes(P => P.ProductType);
            // we can add another include if we want by the way the AddInclude will aggregate it
        }

        // 5.4.26 go to the ProductController ...
    }
}
