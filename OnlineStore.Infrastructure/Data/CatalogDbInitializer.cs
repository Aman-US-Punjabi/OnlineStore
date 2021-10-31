using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Entities.Catalog;

namespace OnlineStore.Infrastructure.Data
{
    public static class CatalogDbInitializer
    {

        public static void Initialize(CatalogDbContext catalogDbContext)
        {
            try
            {
                if (catalogDbContext.Database.GetPendingMigrations().Count() > 0)
                {
                    catalogDbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                // TODO Log Error
                //var logger = services.GetRequiredService<ILogger<Program>>();
                //logger.LogError(ex, "An error occurred migrating the CatalogDB.");
                Console.WriteLine("An error occurred migrating the CatalogDB.");
            }
            SeedProducts(catalogDbContext);
        }

        private static void SeedProducts(CatalogDbContext catalogDbContext)
        {
            // Look for any Products.
            if (catalogDbContext.Products.Any())
            {
                return; // Db has been seeded
            }

            var products = new Product[]
           {
                new Product()
                {
                    Name = "iPhone 12",
                    Price = 1150,
                    Quantity = 12,
                    Description = "Apple iPhone 13, 3 cameras, 100 GB storage, includes a box with charging cable."
                },
                new Product()
                {
                    Name = "iPhone 12 pro",
                    Price = 1250,
                    Quantity = 2,
                    Description = "Apple iPhone 12 pro, 3 cameras, 100 GB storage, includes a box with charging cable."
                },
                new Product()
                {
                    Name = "iPhone 13",
                    Price = 1350,
                    Quantity = 12,
                    Description = "Apple iPhone 13, 3 cameras, 100 GB storage, includes a box with charging cable."
                },
                new Product()
                {
                    Name = "iPhone 13 pro",
                    Price = 1450,
                    Quantity = 12,
                    Description = "Apple iPhone 13 pro, 3 cameras, 100 GB storage, includes a box with charging cable."
                },
           };

            catalogDbContext.Products.AddRange(products);
            catalogDbContext.SaveChanges();
        }
    }
}
