﻿using System;
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
        public ProductWithTypeAndBrandSpecifaication(ProductSpecParam productsParam)
            : base(P =>
            (!productsParam.TypeId.HasValue || P.ProductTypeId == productsParam.TypeId.Value) &&
            (!productsParam.BrandId.HasValue || P.ProductBrandId == productsParam.BrandId.Value)
            )
        {
            AddIncludes(P => P.ProductBrand);
            AddIncludes(P => P.ProductType);

            
            AddOrderBy(P => P.Name);
            if (!string.IsNullOrEmpty(productsParam.Sort))
            {
                switch (productsParam.Sort)
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