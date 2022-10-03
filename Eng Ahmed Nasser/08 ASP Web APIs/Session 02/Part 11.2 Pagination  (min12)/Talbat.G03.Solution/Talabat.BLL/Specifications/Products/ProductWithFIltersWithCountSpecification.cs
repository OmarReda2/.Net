using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications.Products
{
    // ... 12.16 coming from ProductController
    public class ProductWithFIltersWithCountSpecification:BaseSpecification<Product>
    {
        //12.17 add the ctor like ProductWithTypeAndBrandSpecifaication
        public ProductWithFIltersWithCountSpecification(ProductSpecParam productsParam)
            : base(P =>
            (!productsParam.TypeId.HasValue || P.ProductTypeId == productsParam.TypeId.Value) &&
            (!productsParam.BrandId.HasValue || P.ProductBrandId == productsParam.BrandId.Value)
            ){ }
        //12.18 go to the IGenericRepository to make function that calculate the products ...
    }
}
