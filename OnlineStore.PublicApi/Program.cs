using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OnlineStore.Infrastructure.Data;
using OnlineStore.Infrastructure.Identity;

namespace OnlineStore.PublicApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
        }


        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();

                try
                {
                    // Seed Roles and UserRoles data
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var appIdentityDbContext = services.GetRequiredService<AppIdentityDbContext>();

                    AppIdentityDbContextInitializer.SeedAsync(appIdentityDbContext, userManager, roleManager);

                    // Seed Catalog Data
                    //    var catalogContext = services.GetRequiredService<CatalogDbContext>();
                    //    //await CatalogContextSeed.SeedAsync(catalogContext, loggerFactory);
                    var catalogDbContext = services.GetRequiredService<CatalogDbContext>();
                    catalogDbContext.Database.EnsureCreated();
                    CatalogDbInitializer.Initialize(catalogDbContext);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
