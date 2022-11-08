using System;
using GroupProject.Areas.Identity.Data;
using GroupProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GroupProject.Areas.Identity.IdentityHostingStartup))]
namespace GroupProject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserDBContextConnection")));

                services.AddDefaultIdentity<AppliocationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<UserDBContext>();
            });
        }
    }
}