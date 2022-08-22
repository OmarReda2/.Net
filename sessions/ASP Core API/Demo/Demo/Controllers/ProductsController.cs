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
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductBrand> _productBrandRepository;
        private readonly IGenericRepository<ProductType> _productTypeRepository;
        private readonly IMapper _mapper;

        public ProductsController(IGenericRepository<Product> productRepository,
            IGenericRepository<ProductBrand> productBrandRepository,
            IGenericRepository<ProductType> productTypeRepository,  IMapper mapper)
        {
            _productRepository = productRepository;
            _productBrandRepository = productBrandRepository;
            _productTypeRepository = productTypeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProductToReturnDto>> GetProducts()
        {
            var products = await _productRepository.ListAllAsync();
            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products);
            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<Product, ProductToReturnDto>(product);
        }

        [HttpGet]
        [Route("brands")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrand()
        {
            return Ok(await _productBrandRepository.ListAllAsync());
        }

        [HttpGet]
        [Route("types")]
        public async Task<ActionResult<List<ProductBrand>>> GetProducttypes()
        {
            return Ok(await _productTypeRepository.ListAllAsync());
        }
    }
}
