﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Specifications;
using Talabat.BLL.Specifications.Products;
using Talabat.DAL.Entities;
using Talbat.API.DTO;
using Talbat.API.Errors;

namespace Talbat.API.Controllers
{
    public class ProductController : BaseController
    {

        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IGenericRepository<ProductBrand> _brandsRepo;
        private readonly IGenericRepository<ProductType> _typesRepo;
        private readonly IMapper _mapper;


        public ProductController(IGenericRepository<Product> productsRepo
            , IGenericRepository<ProductBrand> brandsRepo
            , IGenericRepository<ProductType> typesRepo
            , IMapper mapper)
        {
            _productsRepo = productsRepo;
            _brandsRepo = brandsRepo;
            _typesRepo = typesRepo;
            _mapper = mapper;
        }



        // ... p9.8 comin from SpecificationsEvaluator
        // p9.9 add sort param as string
        // - sort will be the key that have value
        //   so if we set the value of Key"sort" = priceAsc
        //   the request will be https://localhost:5001/api/Product?sort=priceAsc
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductToReturnDTO>>> GetProducts(string sort)

        {
            var spec = new ProductWithTypeAndBrandSpecifaication(sort);
            // p9.10 add sort param as string and go to the ProductWithTypeAndBrandSpecifaication ctor to define the sort...

            var products = await _productsRepo.GetAllWithSpecAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDTO>>(products));

        }





        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse),StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToReturnDTO>> GetProduct(int id)
        {
            /*
            var spec = new ProductWithTypeAndBrandSpecifaication(id);
            var product = await _productsRepo.GetByIdWithSpecAsync(spec);

            if (product == null) return NotFound(new ApiResponse(404));
            return Ok(_mapper.Map<Product, ProductToReturnDTO>(product));
            */

            // p8.4 editing code
            var spec = new ProductWithTypeAndBrandSpecifaication(id);
            var product = await _productsRepo.GetByIdWithSpecAsync(spec);

            var productDto = _mapper.Map<Product, ProductToReturnDTO>(product);
            if(productDto == null) return NotFound(new ApiResponse(404));
            
            return Ok(productDto);
        }



        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBarnds()
        {
            var brands = await _brandsRepo.GetAllAsync();
            return Ok(brands);
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetTypes()
        {
            var types = await _typesRepo.GetAllAsync();
            return Ok(types);
        }
    }
}
