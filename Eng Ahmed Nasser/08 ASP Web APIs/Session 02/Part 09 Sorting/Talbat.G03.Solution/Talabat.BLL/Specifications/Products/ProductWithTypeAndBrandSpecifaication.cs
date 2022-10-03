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
        // ... p9.10 coming from ProductController
        // p9.11 add the sort to ctor
        public ProductWithTypeAndBrandSpecifaication(string sort)
        {
            AddIncludes(P => P.ProductBrand);
            AddIncludes(P => P.ProductType);

            //p9.12 set the sort value and OrderBy,OrderByDescending (by the AddOrderBy() in the BaseSpecification)
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
