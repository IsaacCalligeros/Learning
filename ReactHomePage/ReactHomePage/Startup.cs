using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using ReactHomePage.Data;
using ReactHomePage.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ReactHomePage.Repositories.Interfaces;
using System.Linq;
using ReactHomePage.Repositories;
using AutoMapper;
using ReactHomePage.Helpers;

namespace ReactHomePage
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
            void AddTransient(Type t)
            {
                var tInter = t.GetInterfaces().FirstOrDefault();
                if (tInter != null) services.AddTransient(tInter, t);
            }

            void AddScoped(Type t)
            {
                var tInter = t.GetInterfaces().FirstOrDefault();
                if (tInter != null) services.AddScoped(tInter, t);
            }

            services.AddHttpClient(HttpClientHelper.Weather, client => {
                client.BaseAddress = new Uri("https://api.openweathermap.org/");
            });

            services.AddHttpClient(HttpClientHelper.Stocks, client => {
                client.BaseAddress = new Uri("https://finnhub.io/api/v1/");
                client.DefaultRequestHeaders.Add("X-Finnhub-Token", Configuration["finnHubKey"]);
            });

            services.AddHttpClient(HttpClientHelper.News, client => {
                //Why do they make it a query paramater...
                client.BaseAddress = new Uri("https://newsapi.org/v2/");
            });

            services.AddSwaggerDocument(configure => configure.Title = "Home page API");

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(options => 
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication()
                .AddIdentityServerJwt();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddHttpContextAccessor();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
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
