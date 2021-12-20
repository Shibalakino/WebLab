using System;
using GameShop.Areas.Identity.Data;
using GameShop.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GameShop.Areas.Identity.IdentityHostingStartup))]
namespace GameShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GameContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GameShopConnection")));

                services.AddDefaultIdentity<GameShopUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    })
                    .AddEntityFrameworkStores<GameContext>();
            });
        }
    }
}