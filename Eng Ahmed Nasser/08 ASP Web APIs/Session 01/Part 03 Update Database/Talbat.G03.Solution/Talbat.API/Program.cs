using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabat.DAL.Data;

namespace Talbat.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            /*CreateHostBuilder(args).Build().Run(); // CreateHostBuilder create kestrel then build it then run it
            StoreContext context = new StoreContext();
            await context.Database.MigrateAsync();*/

            // //p3.1 we used to update database after migration by typing "update-database"
            // - but know we will use another way as we well create object of StpreContext in program an make the migration
            // - unfortunatelly we can't make object of StoreContext as have one instructor
            //   that takes options which be created by DI(the DI create the object in the runtime)
            // - so we want the runtime create that object"StoreContext"
            // - as the main doesn't has a constructor(to let the run time to create an object)
            //   to inject the StoreContext (as we used in mvc), we would make the steps that the runtime 
            //   make it to create the object depended on DI
            // - as we mentioned we used to inject the StoreContext in MVC project, it would create it 
            //  in scope:
            //          - singelton: the lifetime of the object would be exist as the application is exist 
            //          - per request: untill the request finish then object be destroyed  
            //          - per operation: untill the operation finishes in per request 

            // //p3.2 so we want to make scope and create the object(see the steps above)





            // //p3.3 create a host variable and equals it with CreateHostBuilder(args).Build() (which will build the kestrel)
            //   as the kestrel is the place where the DI take place
            //   - we wouldn't use the run() becaue before running we want to apply some operations
            var host = CreateHostBuilder(args).Build();


            // // p3.4 create the scope in the kestreal
            // - host.Services.CreateScope => means that all the services(built-in, user defined) would be in one scope
            // - CreateScope() is an extension method: means that an extension has made it to put the services in this scope
            // - using: as the scope creation is undercontrol of cli
            using var scope = host.Services.CreateScope();

            // //p3.5
            var services = scope.ServiceProvider; // all services in services variable

            // //p3.6
            // creating of the object that log\write the errors in console application
            var loggetFactory = services.GetRequiredService<ILoggerFactory>();


            // //p3.7 creating the object of the context 
            // we put the creation in try and catch, to throw the error in the console as we create the loggerFactory
            try
            {
                var context = services.GetRequiredService<StoreContext>();
                await context.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                // //p3.8 logging the migration error in console
                var logger = loggetFactory.CreateLogger<Program>();
                logger.LogError(ex, "an error occurred during applying migration");
                // or 
                //logger.LogError(ex, ex.Message);

            }

            // //p3.9 finally run the project
            host.Run();

            // //p3.10 run the Program using kestrel



        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
