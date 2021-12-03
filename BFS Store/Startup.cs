using System;
using System.Security.Claims;
using System.Threading.Tasks;
using DAO;
using DAO.Interfaces;
using DAO.Models;
using DAO.Models.Core;
using DAO.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
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
            services.AddMemoryCache();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IAppUsersRepository, AppUsersRepository>();
            services.AddTransient<ICommentsRepository, CommentsRepository>();
            services.AddTransient<ILikesRepository, LikesRepository>();
            
            // services.AddTransient<ICommentsAndLikesRepository, CommentsAndLikesRepository>();
            services.AddDbContext<DataContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("Default")));
            

            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(1));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // services.AddCors();


            services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 6;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();

            services.AddDataProtection().SetApplicationName("BFS Store");
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = ".AspNet.SharedCookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.SlidingExpiration = true;
                options.Events = new CookieAuthenticationEvents
                {
                    OnRedirectToAccessDenied = context =>
                    {
                        PathString requestPath = context.HttpContext.Request.Path;
                        context.HttpContext.Response.Redirect(
                            $"https://localhost:7000?returnUrl={requestPath}");
                        return Task.CompletedTask;
                    },
                    OnRedirectToLogin = context =>
                    {
                        string host = context.HttpContext.Request.Host.Value;
                        PathString requestPath = context.HttpContext.Request.PathAndQuery();
                        context.HttpContext.Response.Redirect(
                            $"https://localhost:7000?returnUrl={host}{requestPath}");
                        return Task.CompletedTask;
                    }
                };
                
            });

            services.AddAuthentication("Identity.Application")

                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
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

            services.AddAuthorization(options =>
            {
                options.AddPolicy("admin", builder => { builder.RequireClaim(ClaimTypes.Role, "admin"); });
                options.AddPolicy("user", builder =>
                {
                    builder.RequireAssertion(c =>
                        c.User.HasClaim(ClaimsIdentity.DefaultRoleClaimType, "user"));
                    // || c.User.HasClaim("email", "User1@shisni.net") ||
                    // c.User.HasClaim(ClaimsIdentity.DefaultNameClaimType, "User1"));
                });
            });

            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });
            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "BFS Store", Version = "v1"});
            });
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

//todo tech debt
//async repositories


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