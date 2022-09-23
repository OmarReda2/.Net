#region Controller/WeatherForecastController
namespace Talbat.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //1- [Route("[controller]")] means: this is the base controler
    //2- any request should include this controller (WeatherForecast)
    //   for example https://localhost:5001/ and then WeatherForecast
     

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        [HttpGet]
        //3- [HttpGet]: means that we have made an get request
        //4- if we make a GET request the https://localhost:5001/WeatherForecast will search the action/endpoint
        //   which have this Verb(GET) 
        // - this endpoint GeT(){} does not be appear in the request

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

#endregion