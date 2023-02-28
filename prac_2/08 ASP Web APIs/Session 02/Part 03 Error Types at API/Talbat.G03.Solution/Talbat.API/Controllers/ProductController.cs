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

namespace Talbat.API.Controllers
{
   

    public class ProductController : BaseController
    {

        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IMapper _mapper;

        // ...p1.6 comming from Helper/MappingProfile
        // p1.7 inject IMapper in ctor
        public ProductController(IGenericRepository<Product> productsRepo, IMapper mapper)
        {
            _productsRepo = productsRepo;
            _mapper = mapper;
        }
        // p1.8 Allow Dependency Injection in Startup 
        // - as the creation of this object(ProductController) depend on the injection of IMapper
        // p1.8 go to Startup...


        [HttpGet]
        //... p1.10 comeback from Startup
        public async Task<ActionResult<IReadOnlyList<ProductToReturnDTO>>> GetProducts()
        // p1.11 make it return IReadOnlyList<ProductToReturnDTO> instead of IReadOnlyList<Product>
        //       as this return will be represented in API
        {
            var spec = new ProductWithTypeAndBrandSpecifaication();
            var products = await _productsRepo.GetAllWithSpecAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDTO>>(products));
            // p1.12 return the mapped entity
        }




       
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductToReturnDTO>> GetProduct(int id)
        // - a mistake in the session before: return IReadOnlyList<Product> instead of Product
        // make the same steps in the prev endpoints
        {
            var spec = new ProductWithTypeAndBrandSpecifaication(id);
            var product = await _productsRepo.GetByIdWithSpecAsync(spec);
            return Ok(_mapper.Map<Product, ProductToReturnDTO>(product));
        }
    }
}
