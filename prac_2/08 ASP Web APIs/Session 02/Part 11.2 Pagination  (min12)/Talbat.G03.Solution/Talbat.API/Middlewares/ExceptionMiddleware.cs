using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Talbat.API.Errors;

namespace Talbat.API.Middlewares
{
    // ... p6.3 coming from TextFile.
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        //p6.4 create ctor and inject
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        //p6.5 create this function that will be use in Middleware in Startup
        //p6.6 go to Startup and this class as Middleware...
        //... p6.8 coming from Startup
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // p6.9
                await _next.Invoke(context);
                // - as this class wil use this funtion as Middleware
                //   so "_next.Invoke(context)" means: that if there no excption errors go to the next Middleware, and we use Invoke we use it to fire the delegate(_next)
            }
            catch (Exception ex)
            //p6.10 
            // - if there any exception we will hanle it here
            {
                //a. we will log the excption in console
                _logger.LogError(ex, ex.Message);

                //b. response of the exc type
                context.Response.ContentType = "application/json";

                //c.StatusCode of the exc
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                //d.Message of the exc , and details
                // - it will be shown in devMode
                // - as we have class "ApiResponse" that have the Message and StatusCode,but we want also to add detailsprop
                // d.1 so we will Errors/ApiExceptionResponse.cs and will imp the "ApiResponse"
                // d.1 go to Errors/ApiExceptionResponse.cs ...

                // ... d.4 come from ApiExceptionResponse.cs
                // d.5 make an obj of ApiExceptionResponse
                var responseMessage = _env.IsDevelopment()
                    ? new ApiExceptionResponse(context.Response.StatusCode, ex.Message, ex.StackTrace.ToString()) // in devMode we will show the StatusCode, Message and Details
                    : new ApiExceptionResponse(context.Response.StatusCode);// in prodMode we will show only the StatusCode

                // d.6 we will convert the responseMessage which is type "ApiExceptionResponse"
                //     to json CamelCase format, as the exc would be shown only in json format
                var options = new JsonSerializerOptions(){ PropertyNamingPolicy = JsonNamingPolicy.CamelCase}; // camel case options
                var json = JsonSerializer.Serialize(responseMessage, options);

                // d.7 finally the excption message is ready
                await context.Response.WriteAsync(json);




            }
        }
    }
}
