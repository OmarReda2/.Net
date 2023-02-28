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
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Repository;
using Talabat.DAL.Data;
using Talbat.API.Errors;
using Talbat.API.Helper;
using Talbat.API.Middlewares;

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

            // ... p2.6
            services.AddSingleton<IConnectionMultiplexer>(S =>
            {
                // p2.7 go to appsetting ...
                // .... p2.8 
                var connection = ConfigurationOptions.Parse(Configuration.GetConnectionString("Redis"));
                return ConnectionMultiplexer.Connect(connection);
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


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

        }




        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //... p6.6 coming from Middlewares/ExceptionMiddleware.cs
            // p6.7 add the Middleware
            app.UseMiddleware<ExceptionMiddleware>();
            //... p6.8 return to Middlewares/ExceptionMiddleware.cs


            if (env.IsDevelopment())
            {
                // ... p6.1 coming from TextFile.cs
                // p6.2 comment the "UseDeveloperExceptionPage()"
                //app.UseDeveloperExceptionPage();
                // p6.2 return to TextFile.cs ....
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
