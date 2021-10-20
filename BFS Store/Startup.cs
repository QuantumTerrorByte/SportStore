using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportStore.Models;
using SportStore.Models.Interfaces;

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
            services.AddMvcCore();
            services.AddMemoryCache();
            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(1));
            services.AddScoped<Cart>(SessionCart.GetCart);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
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
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors(builder => builder.AllowAnyOrigin());          //between routing and endpoints  

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: null,
                    "{category}/Page{productPage:int}",
                    new {Controller = "Product", Action = "Index"}
                );
                endpoints.MapControllerRoute(
                    name: null,
                    "Page{productPage:int}",
                    new {Controller = "Product", Action = "Index", productPage = 1}
                );
                endpoints.MapControllerRoute(
                    name: null,
                    "{category}",
                    new {Controller = "Product", Action = "Index", productPage = 1}
                );
                endpoints.MapControllerRoute(
                    name: null,
                    "",
                    new {Controller = "Product", Action = "Index", productPage = 1}
                );
                endpoints.MapControllerRoute(
                    name: null,
                    "{controller=Product}/{action=Index}/{id?}"
                );


                // endpoints.MapControllerRoute(
                // name: "pagination",
                // pattern: "Products/Page{productPage}",
                // new {Controller = "Product", Action = "Index"}
                // );
                // endpoints.MapControllerRoute(
                // name: "default",
                // pattern: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}