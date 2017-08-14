using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using cEs.Application.Interface.Seguranca;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using cEs.Application.Seguranca;
using cEs.Application.Interface;
using cEs.Domain.Interface.Repositories.Seguranca;
using static cEs.Infra.Configuracoes.Geral;
using cEs.Portal.MenuHelpers;
using cEs.Infra.Email.Config;
using cEs.Infra;
using cEs.DataAccess.Seguranca;
using cEs.Infra.Configuracoes.Data;
using Microsoft.EntityFrameworkCore;
using cEs.Infra.Authentication.DataModel;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Localization;
using System;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace cEs.Portal
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddTransient<IPaginaMenuAppService, PaginaMenuAppService>();
            services.AddTransient<IAcessoAppService, AcessoAppService>();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            //services.AddDbContext<DbConexao>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexao")));

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));



            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                    options.Cookies.ApplicationCookie.AccessDeniedPath = "/home/access-denied")
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<DbConexao>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<EmailConfig>(Configuration.GetSection("Email"));


            services.AddTransient<IPaginaMenuRepository, PaginaMenuRepository>();
            services.AddTransient<IAcessoRepository, AcessoRepository>();
            services.AddScoped<MenuPesquisa>();

            services.AddScoped<PaginaMenuAppService>();
            services.AddMvc()
                .AddViewLocalization()
                .AddDataAnnotationsLocalization();

            //services.AddScoped<LanguageActionFilter>();

            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = new List<CultureInfo>
                        {
                            new CultureInfo("pt-BR"),
                        };

                    options.DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();

            services.Configure<IdentityOptions>(options =>
            {
                options.SecurityStampValidationInterval = TimeSpan.FromSeconds(60);
            });


            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseIdentity();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static void RegisterServices(IServiceCollection services)
        {
            // Adding dependencies from another layers (isolated from Presentation)
            SimpleInjectorBootStrapper.RegisterServices(services);
        }

    }
}
