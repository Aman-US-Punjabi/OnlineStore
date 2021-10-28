using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OnlineStore.AdminBlazorServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();

                //try
                //{
                //    var catalogContext = services.GetRequiredService<CatalogDbContext>();
                //    //await CatalogContextSeed.SeedAsync(catalogContext, loggerFactory);

                //    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                //    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                //    await AppIdentityDbContextSeed.SeedAsync(userManager, roleManager);
                //}
                //catch (Exception ex)
                //{
                //    var logger = loggerFactory.CreateLogger<Program>();
                //    logger.LogError(ex, "An error occurred seeding the DB.");
                //}
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
