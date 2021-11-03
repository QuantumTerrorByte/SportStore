using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportStore.Models;
using SportStore.Models.Core;
using SportStore.Models.DAO;
using SportStore.Models.DAO.Interfaces;

namespace SportStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProductRepository, EfProductRepository>();
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddDbContext<DataContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("Default")));
            // services.AddMvcCore();
            services.AddMemoryCache();
            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(1));
            services.AddScoped<Cart>(provider => SessionCart.GetCart(provider));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });
            services.AddCors();
            services.AddControllers().AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors(builder => builder.AllowAnyOrigin());          //between routing and endpoints  

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}");
                // endpoints.MapControllerRoute(
                //     name: null,
                //     "{category}/Page{productPage:int}",
                //     new {Controller = "Product", Action = "Index"}
                // );
                // endpoints.MapControllerRoute(
                //     name: null,
                //     "Page{productPage:int}",
                //     new {Controller = "Product", Action = "Index", productPage = 1}
                // );
                // endpoints.MapControllerRoute(
                //     name: null,
                //     "{category}",
                //     new {Controller = "Product", Action = "Index", productPage = 1}
                // );
                // endpoints.MapControllerRoute(
                //     name: null,
                //     "",
                //     new {Controller = "Product", Action = "Index", productPage = 1}
                // );
                // endpoints.MapControllerRoute(
                //     name: null,
                //     "{controller=Product}/{action=Index}/{id?}"
                // );
                

                // endpoints.MapControllerRoute(
                // name: "pagination",
                // pattern: "Products/Page{productPage}",
                // new {Controller = "Product", Action = "Index"}
                // );
                // endpoints.MapControllerRoute(
                // name: "default",
                // pattern: "{controller=Product}/{action=Index}/{id?}");
            });
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}