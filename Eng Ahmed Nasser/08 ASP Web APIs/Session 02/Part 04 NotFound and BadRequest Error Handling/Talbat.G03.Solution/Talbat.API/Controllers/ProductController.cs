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

namespace Talbat.API.Controllers
{
   

    public class ProductController : BaseController
    {

        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IMapper _mapper;

        // ...p1.6 comming from Helper/MappingProfile
        // if you to continue p1 please go to p1
        public ProductController(IGenericRepository<Product> productsRepo, IMapper mapper)
        {
            _productsRepo = productsRepo;
            _mapper = mapper;
        }
        


        [HttpGet]
        
        public async Task<ActionResult<IReadOnlyList<ProductToReturnDTO>>> GetProducts()
       
        {
            var spec = new ProductWithTypeAndBrandSpecifaication();
            var products = await _productsRepo.GetAllWithSpecAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDTO>>(products));
            
        }




       
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductToReturnDTO>> GetProduct(int id)
        {
            var spec = new ProductWithTypeAndBrandSpecifaication(id);
           
            var product = await _productsRepo.GetByIdWithSpecAsync(spec);
            //p4.6 coming from BuggyContoller
            //p4.6 add the condition when product, & return to BuggyContoller ...
            if (product == null) return NotFound(new ApiResponse(404));

            return Ok(_mapper.Map<Product, ProductToReturnDTO>(product));
        }
    }
}
