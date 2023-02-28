using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
using Talabat.DAL.Entities.Identity;
using Talabat.DAL.Identity;

namespace Talbat.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           
            var host = CreateHostBuilder(args).Build();


            
            using var scope = host.Services.CreateScope();

            
            var services = scope.ServiceProvider; 
            var loggetFactory = services.GetRequiredService<ILoggerFactory>();


            
            try
            {
                var context = services.GetRequiredService<StoreContext>();
                await context.Database.MigrateAsync();
                await StoreContextSeed.seedAsync(context, loggetFactory);

                // ... p5.15 
                // p5.16 
                var identityContext = services.GetRequiredService<AppIdentityDbContext>();
                await identityContext.Database.MigrateAsync();
                // p5.17 go to startup to addIdentity ...

                //...p.25 
                //p.26 
                var userManager = services.GetRequiredService<UserManager<AppUser>>();
                await AppIdentityDbContextSeed.SeedUserAsync(userManager);
            }
            catch (Exception ex)
            {
                var logger = loggetFactory.CreateLogger<Program>();
                logger.LogError(ex, "an error occurred during applying migration");

            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
