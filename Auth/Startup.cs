using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Auth.Infrastructure;
using Auth.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace Auth
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPasswordValidator<AspNetUser>, UserPasswordValidator>();

            services.AddDbContext<UserIdentityContext>(options =>
            {
                options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddDefaultIdentity<AspNetUser>(options =>
                {
                    options.User.RequireUniqueEmail = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 6;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<UserIdentityContext>()
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
                        string requestPath = context.HttpContext.Request.PathBase;
                        context.HttpContext.Response.Redirect(
                            $"https://localhost:7000?returnUrl={host}{requestPath}");
                        return Task.CompletedTask;
                    }
                };
            });


            services.AddAuthentication("Identity.Application")
                // .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                // {
                //     options.Cookie.HttpOnly = true;
                //     options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                //     options.SlidingExpiration = true;
                //     options.LoginPath = "/AuthMvc/Login/";
                // })
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
                options.AddPolicy("admin",
                    builder => { builder.RequireClaim(ClaimsIdentity.DefaultRoleClaimType, "admin"); });
                options.AddPolicy("user", builder =>
                {
                    builder.RequireAssertion(c =>
                        c.User.HasClaim(ClaimsIdentity.DefaultRoleClaimType, "user"));
                    // || c.User.HasClaim("email", "User1@shisni.net") ||
                });
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=AuthEmployee}/{action=SignIn}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}