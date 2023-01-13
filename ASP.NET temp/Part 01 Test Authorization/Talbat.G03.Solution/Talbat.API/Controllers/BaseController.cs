using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Talbat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // means that when we make a request in these controller it well route in
    // baseUrl/api/controller (the same controller that we have made the same request)
    public class BaseController : ControllerBase
    {
        
    }
}
