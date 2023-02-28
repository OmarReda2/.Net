using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Talabat.DAL.Entities.Identity;
using Talabat.DAL.Identity;

namespace Talbat.API.Extensions
{
    //...p5.18
    //p5.19
    public static class IdentityServiceExtension
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>(options =>
                {

                }).AddEntityFrameworkStores<AppIdentityDbContext>();
            return services;
        }
    }

    // p5.20 go to Startup to add this service...
}
