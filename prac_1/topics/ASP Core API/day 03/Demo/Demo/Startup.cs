using Demo.Extensions;
using Demo.Helper;
using Demo.Middleware;
using Infrastructure.Data;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Demo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddControllers();
            services.AddDbContext<StoreContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DeafaultConnection")));

            services.AddDbContext<AppIdentityDbContext>(x =>
                x.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddSingleton<IConnectionMultiplexer>(config =>
            {
                var configuration = ConfigurationOptions.Parse(Configuration.GetConnectionString("Redis"), true);
                return ConnectionMultiplexer.Connect(configuration);
            });

            services.AddApplicationServices();

            services.AddIdentityServices(Configuration);

            services.AddSwaggerDocumentation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseStatusCodePagesWithReExecute("/errors/{0}");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseAuthorization();
            
            app.UseSwaggerDocumentation();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
