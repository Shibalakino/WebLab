using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using GameShop.Data;
using GameShop.Areas.Identity.Data;

namespace GameShop
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
            //string connection = Configuration.GetConnectionString("GameShopGamesContextConnection");
            //services.AddDbContext<GameContext>(options => options.UseSqlServer(connection));

            //connection = Configuration.GetConnectionString("GameShopUsersContextConnection");
            //services.AddDbContext<GameShopUserContext>(options => options.UseSqlServer(connection));

            //string connection = Configuration.GetConnectionString("GameShopConnection");
            //services.AddDbContext<GameShopUserContext>(options => options.UseSqlServer(connection));

            string connection = Configuration.GetConnectionString("GameShopConnection");
            services.AddDbContext<GameContext>(options => options.UseSqlServer(connection));

            //services.AddMvc();
            //services.AddIdentityCore<GameShopUser>().AddEntityFrameworkStores<GameContext>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization(); //??

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");
                endpoints.MapRazorPages();
            });
        }
    }
}