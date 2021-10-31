using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Core;

namespace OnlineStore.Infrastructure.Identity
{
    public static class AppIdentityDbContextInitializer
    {
        public static void SeedAsync(AppIdentityDbContext appIdentityDbContext, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            try
            {
                if (appIdentityDbContext.Database.GetPendingMigrations().Count() > 0)
                {
                    appIdentityDbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                //var logger = services.GetRequiredService<ILogger<Program>>();
                //logger.LogError(ex, "An error occurred migrating the AppIdentityDB.");
                // TODO Log error
                Console.WriteLine("An error occurred migrating the AppIdentityDB.");
            }

            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var adminUser = new ApplicationUser
                {
                    Email = SD.Admin_Email,
                    UserName = SD.Admin_Email,
                    FirstName = "Aman",
                    LastName = "Singh",
                    EmailConfirmed = true
                };

                IdentityResult result = userManager.CreateAsync(adminUser, SD.Admin_Password).Result;

                if (result.Succeeded)
                {
                    var admin = userManager.FindByNameAsync(SD.Admin_Email).Result;
                    userManager.AddToRolesAsync(admin, new[] { SD.Role_Admin }).Wait();
                }
            }
        }

        // TODO Currently when we add user and add admin role while creating User, If statement
        // fails because there is already UserRole admin in the roles. So, no roles are being created
        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                var roles = new List<IdentityRole>
                {
                    new IdentityRole{ Name = SD.Role_Admin },
                    new IdentityRole{ Name = SD.Role_Customer },
                    new IdentityRole{ Name = SD.Role_Employee }
                };

                foreach (var role in roles)
                {
                    roleManager.CreateAsync(role).Wait();
                }
            }
        }
    }
}
