using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportStore.Models;

namespace SportStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddSingleton<IProductRepository, FaceProductRepository>();
            services.AddTransient<IProductRepository, DataContext>();
            services.AddDbContext<DataContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

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