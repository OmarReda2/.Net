using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.Controllers
{
    public class MoviesController : Controller
    {


        #region ContentResult and RedirectResult 
        ////public string Index()
        ////{
        ////    return "Index";
        ////}

        //public ContentResult Index()
        //{
        //    /*
        //    ContentResult result = new ContentResult();
        //    result.Content = "Index";
        //    //result.ContentType = "object/pdf"; // type of result
        //    return result;
        //    */
        //    // or use HelperMethods

        //    return Content("Index");
        //}

        //public RedirectResult Omar()
        //{
        //    /*
        //     RedirectResult result = new RedirectResult("https://localhost:44318/Movies/Index"); // redirect to the IndexAction
        //     return result;            
        //     */
        //    // or use HelperMethods

        //    return Redirect("https://localhost:44318/Movies/Index");
        //}
        #endregion


        #region IActionResult
        //// ContentResult and RedirectResult imp => IActionResult
        //public IActionResult Index()
        //{

        //    return Content("Index");
        //}

        //public IActionResult Omar()
        //{
        //    //return Redirect("https://localhost:44318/Movies/Index"); // or use the dynamic one
        //    //return RedirectToAction("Index"); //or use the typeOf
        //    //return RedirectToAction(nameof(Index));
        //    return RedirectToRoute("defualt"); //name of endPiont in Startup
        //}
        #endregion


        #region modelBinding
        /* 
         public IActionResult GetMovie(int? id) 
             // - id from form (use postman to test)
             //   or from query string ex. GetMovie?id=1
             //   or from segment in endPoint in Startup
             //   or from file ex. pdf
         {
             return Content($"Movie With {id}");
         }
        */


        /*
        public IActionResult GetMovie(int? id, string name, Employee employee)
        // test in debug mode
        // https://localhost:5001/Movies/GetMovie?id=1&name=ali&emplyee.id=5&emplyee.name=omar
        {
            return Content($"Movie With {id}");
        }
        #endregion
        */


        public IActionResult GetMovie(int? id, int[] arr)
        // test in debug mode
        //https://localhost:5001/movies/getmovie?id=1&arr[0]=2
        { 
            return Content($"Movie With {id}");
        }
        #endregion

    }
}
