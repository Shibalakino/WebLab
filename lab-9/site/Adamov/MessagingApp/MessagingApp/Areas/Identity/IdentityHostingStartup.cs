using MessagingApp.Areas.Identity.Data;
using MessagingApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(MessagingApp.Areas.Identity.IdentityHostingStartup))]
namespace MessagingApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MessageContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MessagingAppConnection")));
                //context.Configuration.GetConnectionString("MessagingAppContextConnection")));

                services.AddDefaultIdentity<MessagingAppUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                    .AddEntityFrameworkStores<MessageContext>();
            });
        }
    }
}