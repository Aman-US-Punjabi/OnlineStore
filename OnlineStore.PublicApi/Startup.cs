using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OnlineStore.Infrastructure.Data;
using OnlineStore.Infrastructure.Identity;

namespace OnlineStore.PublicApi
{
    public class Startup
    {
        private const string CORS_POLICY = "CorsPolicy";

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


        private void ConfigureInMemoryDatabases(IServiceCollection services)
        {
            services.AddDbContext<CatalogDbContext>(c =>
                c.UseInMemoryDatabase("Catalog"));

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseInMemoryDatabase("Identity"));

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

        public void ConfigureTestingServices(IServiceCollection services)
        {
            ConfigureInMemoryDatabases(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppIdentityDbContext>()
                    .AddDefaultTokenProviders();

            //var baseUrlConfig = new BaseUrlConfiguration();
            //Configuration.Bind(BaseUrlConfiguration.CONFIG_NAME, baseUrlConfig);

            //services.AddMemoryCache();

            //var key = Encoding.ASCII.GetBytes(AuthorizationConstants.JWT_SECRET_KEY);
            //services.AddAuthentication(config =>
            //{
            //    config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(config =>
            //{
            //    config.RequireHttpsMetadata = false;
            //    config.SaveToken = true;
            //    config.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});

            //services.AddCors(options =>
            //{
            //    options.AddPolicy(name: CORS_POLICY,
            //                      builder =>
            //                      {
            //                          builder.WithOrigins(baseUrlConfig.WebBase.Replace("host.docker.internal", "localhost").TrimEnd('/'));
            //                          builder.AllowAnyMethod();
            //                          builder.AllowAnyHeader();
            //                      });
            //});

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OnlineStore.PublicApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OnlineStore.PublicApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
