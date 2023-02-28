using System;

namespace Talbat.API.Errors
{
    //... p4.1 coming from Textfile.cs
    public class ApiResponse
    {
        // - as the important thing in the response of api errors is the status code and and the message
        //p4.2   so we will create 2prop: Message, StatusCode
        public int StatusCode { get; set; }
        public string Message { get; set; }

        //p4.3 create the ctor that takes Message and StatusCode
        //     so any one would create obj of ApiResponse should define Message and StatusCode 
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode); // if null call this function 
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        => statusCode switch // new syntax for switch
        {
            400 => "A Bad Request, You Have Made",
            401 => "Authorized, You Are Not",
            404 => "Resources Was Not Found",
            505 => "Server Error",
            _ => null
        };

        //p4.4 to apply these error format go to BuggyController ...
    }
}
