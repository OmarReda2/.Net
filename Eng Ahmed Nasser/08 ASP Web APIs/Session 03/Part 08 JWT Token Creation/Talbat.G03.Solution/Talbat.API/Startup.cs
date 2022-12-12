using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
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
using Talabat.DAL.Entities.Identity;
using Talabat.DAL.Identity;
using Talbat.API.Errors;
using Talbat.API.Extensions;
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
            services.AddSingleton<IConnectionMultiplexer>(S =>
            {
                var connection = ConfigurationOptions.Parse(Configuration.GetConnectionString("Redis"));
                return ConnectionMultiplexer.Connect(connection);
            });
            // ... p5.7 
            // p5.8
            services.AddDbContext<AppIdentityDbContext>(options =>
            {
                // p5.9 go to appsetting to add ConnectionString ...
                // ... p5.11
                //p5.12 
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection"));
                // p5.13 Add Migration
                // p5.14 go to Program to updateDatabase
            });
            // ... p5.17
            // p5.18 create Talbat.API.Extensions.IdentityServiceExtension to add IdentityService

            // ...p5.20
            //p5.21
            services.AddIdentityService(Configuration);
            services.AddApplicationServices();
            //p5.22
            //services.AddAuthentication(); // to add users instead of repository
            //p5.23 create Talabat.DAL.Identity.AppIdentityDbContextSeed
            //p5.23 go to Talabat.DAL.Identity.AppIdentityDbContextSeed...
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
