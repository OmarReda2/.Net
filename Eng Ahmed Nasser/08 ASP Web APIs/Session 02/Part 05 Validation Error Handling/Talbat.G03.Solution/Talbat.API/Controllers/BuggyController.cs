using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.DAL.Data;
using Talbat.API.Errors;

namespace Talbat.API.Controllers
{
    //... p3.1 coming from Textfile.cs
    // to continue steps of p3 please go to the part before
    public class BuggyController : BaseController
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)
        {
            _context = context;
        }


        // ... p4.4 coming from  Errors/ApiResponse
        // p4.5 add ApiResponse obj in NotFound() with the suitable status code
        // p4.6 go to ProductController to add ApiResponse obj ...
        [HttpGet("notfound")] 
        public ActionResult GetNotFoundRequest()
        {
            var product = _context.Product.Find(100);
            if (product == null) return NotFound(new ApiResponse(404));
            return Ok();
        }


        
        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            var product = _context.Product.Find(100);
            var productToReturnDto = product.ToString(); 
            return Ok();
        }



        
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }



        // e. 4th error
        [HttpGet("badrequest/{id}")]
        public ActionResult GetBadRequest(int id) // validation error
        {
            return BadRequest();
        }


        //p3.3 for more details go to postman in Error handling Error
    }
}
