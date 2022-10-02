using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.DAL.Data;

namespace Talbat.API.Controllers
{
    //... p3.1 coming from Textfile.cs
    public class BuggyController : BaseController
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)// we will inject context instead of repo only to demonistrate the errors type in API
        {
            _context = context;
        }

        //p3.2 types of errors
        //- we want to make the all different errors with same stamp so the frontend dev can work with it
       
        
        
        //a. 1st error type: Not found
        [HttpGet("notfound")] // when the user make request to https://5001/BuggyController/notfound will go to this end point
        public ActionResult GetNotFoundRequest()
        {
            var product = _context.Product.Find(100);
            if(product == null) return NotFound();
            return Ok();
        }


        //b. 2nd error: Get Null Ref Error
        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            var product = _context.Product.Find(100);
            var productToReturnDto = product.ToString(); // Exception [NullReferenceException]
            return Ok();
        }


        // c. 3rd error: bad request or 400 error
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest();
        }



        // e. 4th error: validation Error
        [HttpGet("badrequest/{id}")]
        public ActionResult GetBadRequest(int id) // validation error
        {
            return BadRequest();
        }


        // f. 5th error: not found end point
        // - see in postman in Error handling folder


        //p3.3 for more details go to postman in Error handling Error
    }
}
