using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications.Products
{
    public class ProductWithTypeAndBrandSpecifaication : BaseSpecification<Product>
    {
        // ... p10.3 coming from ProductController
        // p10.4 chain this ctor with the base
        public ProductWithTypeAndBrandSpecifaication(string sort, int? typeId, int? brandId)
            //- this is the filteration as the criteria will be assigned so when we build the query
            //  in "specificationEvaluator" it will add where conditon
            //  that willo return a list that has the selected ProductTypeId and ProductBrandId
            : base(P =>
            (!typeId.HasValue || P.ProductTypeId == typeId.Value) &&
            (!brandId.HasValue || P.ProductBrandId == brandId.Value)
            )
        {
            AddIncludes(P => P.ProductBrand);
            AddIncludes(P => P.ProductType);

            
            AddOrderBy(P => P.Name);
            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(P => P.Price);
                        break;

                    case "priceDesc":
                        AddOrderByDescending(P => P.Price);
                        break;

                    default:
                        AddOrderBy(P => P.Name);
                        break;
                }
            }
        }








        public ProductWithTypeAndBrandSpecifaication(int id) : base(P => P.id == id)
        {
            AddIncludes(P => P.ProductBrand);
            AddIncludes(P => P.ProductType);
        }

    }



}
