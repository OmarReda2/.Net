using System.Collections;

namespace Talbat.API.Errors
{
    // ... p5.1 coming from TextFile.cs
    //p5.2 imp the ApiResponse to have the sameProp
    public class ApiValidationErrorResponse:ApiResponse
    {
        //p5.3 make the ctor and chain the base
        public ApiValidationErrorResponse():base(400)
        {

        }
        //p5.4 add the additional prop
        public IEnumerable Errors { get; set; }
        //p5.5 go to Startup...
        // as we want to add the validation errors in this array


    }
}
