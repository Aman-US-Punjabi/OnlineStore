using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineStore.AdminBlazorServer.Areas.Identity;
using OnlineStore.AdminBlazorServer.Data;
using OnlineStore.Infrastructure.Data;
using OnlineStore.Infrastructure.Identity;

namespace OnlineStore.AdminBlazorServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // Configure Services for Development Environment
        // Project will use these Configuration Services while running in Dev mode
        public void ConfigureDevelopmentServices(IServiceCollection services)
        {

            services.AddDbContext<CatalogDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("CatalogDbConnection")));

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("IdentityConnection")));

            ConfigureServices(services);
        }


        // Configure Services for Production Environment
        // Project will use these Configuration Services while running in Production mode
        public void ConfigureProductionServices(IServiceCollection services)
        {

            Console.WriteLine("****************** Production   **************************");
            services.AddDbContext<CatalogDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("CatalogDbConnection")));

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("IdentityConnection")));


            ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddDefaultUI()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
