using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Demo.Dtos;
using Demo.Errors;
using Demo.Helper;
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
        public async Task<ActionResult<ProductToReturnDto>> GetProducts([FromQuery]ProductSpecParams productParams)
        {
            var spec = new ProductsWithTypesAndBrandsSpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecificaton(productParams);

            var totalItems = await _productRepository.CountAsync(countSpec);

            var products = await _productRepository.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products);
            return Ok(new Pagination<ProductToReturnDto>(productParams.PageIndex, productParams.PageSize, totalItems, data));
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse),StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var spec = new ProductsWithTypesAndBrandsSpecification(id);
            var product = await _productRepository.GetEntityWithSpec(spec);
            if (product == null) return NotFound(new ApiResponse(404));
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
