using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications.Products
{
    
    public class ProductWithFIltersWithCountSpecification:BaseSpecification<Product>
    {
        
        public ProductWithFIltersWithCountSpecification(ProductSpecParam productsParam)
            : base(P =>
            // ... p1.3
            (string.IsNullOrEmpty(productsParam.Search) || (P.Name.ToLower().Contains(productsParam.Search))) &&
            (!productsParam.TypeId.HasValue || P.ProductTypeId == productsParam.TypeId.Value) &&
            (!productsParam.BrandId.HasValue || P.ProductBrandId == productsParam.BrandId.Value)
            ){ }
        
    }
}
