using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Talabat.DAL.Entities.Identity;
using Talabat.DAL.Identity;

namespace Talbat.API.Extensions
{
    //...p5.18
    //p5.19
    public static class IdentityServiceExtension
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<AppUser, IdentityRole>(options =>
                {

                }).AddEntityFrameworkStores<AppIdentityDbContext>();
            
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) /// validate token: as every time token been sent we validate on
            services.AddAuthentication(
                options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    /// we use this instead of [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] 
                    /// but we will still use "[Authorize]"
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = true,
                        ValidAudience = configuration["JWT:ValidAudience"],
                        ValidateIssuer = true,
                        ValidIssuer = configuration["JWT:ValidIssuer"],
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"])),
                        ValidateLifetime = true,
                    };
                }) ;
            return services;
        }
    }

    // p5.20 go to Startup to add this service...
}
