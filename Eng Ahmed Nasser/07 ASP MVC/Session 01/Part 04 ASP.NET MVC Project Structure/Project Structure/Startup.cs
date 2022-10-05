using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Structure
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
            // services use Dependency Injection
        {
            services.AddControllersWithViews(); // MVC
            //services.AddControllers(); // API
            //services.AddRazorPages(); // Razor Pages
            //services.AddMvc(); //All

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{Action}/{id?}"
                    //pattern: "{controller=Movies}/{Action=Index}/{id:int?}" // defualt values or use the old syntax:
                    //,defaults: new {controller = "Movies", action = "Index"}

                    //pattern: "Omar/aa{controller=Movies}/{Action=Index}/{id:int?}" // segments type or use the old syntax:
                    //,constraints: new { id = new IntRouteConstraint()}


                    );
            });
        }
    }
}
