namespace Talbat.API.Errors
{
    // ... p6.10 : d.1
    //     coming from Middlewares/ExceptionMiddleware
    public class ApiExceptionResponse:ApiResponse
    {
        // d.2 create details prop
        public string Details { get; set; }

        // d.3 create ctor with chaining
        public ApiExceptionResponse(int statusCode, string message = null, string details = null)
            :base(statusCode, message)
        // we make the message and details allow null, as in the production mode would be null
        {
            Details = details;
        }
        // d.4 return to ExceptionMiddleware.cs ...
    }
}
