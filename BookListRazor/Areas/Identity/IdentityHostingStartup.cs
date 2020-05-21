using System;
using BookListRazor.Areas.Identity.Data;
using BookListRazor.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BookListRazor.Areas.Identity.IdentityHostingStartup))]
namespace BookListRazor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BookListRazorContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BookListRazorContextConnection")));

                services.AddDefaultIdentity<BookListRazorUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BookListRazorContext>();
            });
        }
    }
}