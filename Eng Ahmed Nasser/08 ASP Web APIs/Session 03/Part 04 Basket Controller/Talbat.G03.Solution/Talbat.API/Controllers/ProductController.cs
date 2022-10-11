using AutoMapper;
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
using Talbat.API.Helper;

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



        
        [HttpGet]
        public async Task<ActionResult<Pagination<ProductToReturnDTO>>> GetProducts([FromQuery] ProductSpecParam productsParam)

        {
           
            var spec = new ProductWithTypeAndBrandSpecifaication(productsParam);
            var products = await _productsRepo.GetAllWithSpecAsync(spec);
            var Data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDTO>>(products);

            
            var countSpec = new ProductWithFIltersWithCountSpecification(productsParam);
            var count = await _productsRepo.GetCountAsync(countSpec);
            return Ok(new Pagination<ProductToReturnDTO>(productsParam.PageIndex
               , productsParam.PageSize, count, Data));

        }





        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToReturnDTO>> GetProduct(int id)
        {
            
            var spec = new ProductWithTypeAndBrandSpecifaication(id);
            var product = await _productsRepo.GetByIdWithSpecAsync(spec);

            var productDto = _mapper.Map<Product, ProductToReturnDTO>(product);
            if (productDto == null) return NotFound(new ApiResponse(404));

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
