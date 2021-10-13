
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;
using Microsoft.Extensions.Options;


namespace JShope
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
            services.AddMvc();
            
                services.AddControllersWithViews();

            services.AddDbContext<JShopeContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("JShopConnection")/*"Data Source =.;Initial Catalog=JShop_DB;Integrated Security=true" *//*"Server =.; Initial Catalog = JShop_DB; User ID = javad; Password = 4Vmbw0@5; MultipleActiveResultSets = true"*/);
            });


            services.AddTransient<IUserService, UserService>();

            services.AddScoped<IProductService, PoroductService>();
            services.AddScoped<ISiteService, SiteService>();

            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(options =>
            {
                options.LoginPath = "/user/Login";
                options.LogoutPath = "/Logout";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);


            });

            #endregion
        }

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment())
            {
               
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();
            


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();

            });
        }
    }
}
