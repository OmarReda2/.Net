using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Demo.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Controllers
{

    public class ProductsController : BaseApiController
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProductToReturnDto>> GetProducts()
        {
            var products = await _productRepository.GetProductsAsync();
            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products);
            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            return _mapper.Map<Product, ProductToReturnDto>(product);
        }

        [HttpGet]
        [Route("brands")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrand()
        {
            return Ok(await _productRepository.GetProductsBrandsAsync());
        }

        [HttpGet]
        [Route("types")]
        public async Task<ActionResult<List<ProductBrand>>> GetProducttypes()
        {
            return Ok(await _productRepository.GetProductsTypesAsync());
        }
    }
}
