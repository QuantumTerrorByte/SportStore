using System;
using System.Security.Claims;
using DAO;
using DAO.Interfaces;
using DAO.Models.Core;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SportStore.Infrastructure;
using SportStore.Models;
using SportStore.Models.Core;

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
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            // services.AddTransient<ICommentsAndLikesRepository, CommentsAndLikesRepository>();
            
            services.AddDbContext<DataContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddDbContext<UserIdentityContext>(options =>
            {
                options.UseMySQL(Configuration.GetConnectionString("Default"));
            });
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "BFS Store", Version = "v1"}); });
            
            services.AddMemoryCache();
            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(1));
            services.AddScoped<Cart>(provider => SessionCart.GetCart(provider));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers().AddNewtonsoftJson(); // todo controller options
            services.AddCors();
            
            services.AddTransient<IPasswordValidator<AspNetUser>, UserPasswordValidator>();
            services.AddIdentity<AspNetUser, IdentityRole>(options => {
                    options.User.RequireUniqueEmail = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 6;
                })
                .AddEntityFrameworkStores<UserIdentityContext>()
                .AddDefaultTokenProviders();
            services.AddAuthentication()
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options => {
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                    options.SlidingExpiration = true;
                    options.LoginPath = "/AuthMvc/Login/";
                })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options => {
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = JwtOptions.ISSUER,
                    ValidateAudience = true,
                    ValidAudience = JwtOptions.AUDIENCE,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = JwtOptions.GetKey(),
                };
            });
            services.AddAuthorization(options => {
                options.AddPolicy("admin", builder =>
                {
                    builder.RequireClaim(ClaimsIdentity.DefaultRoleClaimType, "admin");
                });
                options.AddPolicy("user", builder =>
                {
                    builder.RequireAssertion(c =>
                        c.User.HasClaim(ClaimsIdentity.DefaultRoleClaimType, "user"));
                    // || c.User.HasClaim("email", "User1@shisni.net") ||
                    // c.User.HasClaim(ClaimsIdentity.DefaultNameClaimType, "User1"));
                });
            });
            
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BFS Store v1"));
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSpaStaticFiles();
            // app.UseCors(builder => builder.AllowAnyOrigin()); //between routing and endpoints  

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}");
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