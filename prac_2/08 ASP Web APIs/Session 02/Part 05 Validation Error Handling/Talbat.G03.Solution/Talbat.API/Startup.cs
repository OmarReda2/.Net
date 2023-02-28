using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Repository;
using Talabat.DAL.Data;
using Talbat.API.Errors;
using Talbat.API.Helper;


namespace Talbat.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Talbat.API", Version = "v1" });
            });


            services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            services.AddAutoMapper(typeof(MappingProfile));

            // ... p5.5 coming from Errors/ApiValidationErrorResponse
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                // - ActionContext:lambda exp that takes 1 param is the context of the endPoint
                //   or the container the have the configuration of the endPoint
                {
                    var errors = actionContext.ModelState.Where(M => M.Value.Errors.Count > 0) // the actionContext have(dictionary) more than ModelState so we will select the one which have errors
                                              .SelectMany(M => M.Value.Errors) // from the modelState select the errors(Array of obi each obj have ErrorMessage and other prop)         
                                              .Select(M => M.ErrorMessage) // select the error message from the Errors obj
                                              .ToArray();

                    //p5.6 we want to change the message that appear when validation error
                    //     so we create obj of ApiValidationErrorResponse

                    var responseMessage = new ApiValidationErrorResponse()
                    {
                        Errors = errors // equals the errors in ApiValidationErrorResponse with error created here
                    };

                    return new BadRequestObjectResult(responseMessage); // as the message that appears is represented as BadRequestObjectResult()
                };
            });

        }




        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Talbat.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
