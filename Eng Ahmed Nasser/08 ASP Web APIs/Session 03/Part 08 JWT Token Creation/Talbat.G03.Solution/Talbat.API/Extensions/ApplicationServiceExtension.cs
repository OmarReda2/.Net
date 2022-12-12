using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Repository;
using Talabat.BLL.Services;
using Talbat.API.Errors;
using Talbat.API.Helper;

namespace Talbat.API.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var errors = actionContext.ModelState.Where(M => M.Value.Errors.Count > 0)
                                              .SelectMany(M => M.Value.Errors)
                                              .Select(M => M.ErrorMessage)
                                              .ToArray();




                    var responseMessage = new ApiValidationErrorResponse()
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(responseMessage);
                };
            });
            services.AddScoped(typeof(ITokenService), typeof(TokenService));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            // ... p4.3
            // p4.4
            services.AddScoped(typeof(IBasketRepository), typeof(BasketRepository));
            // p4.5 return to BasketController ...


            return services;

        }
    }
}
