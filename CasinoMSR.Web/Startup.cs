using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using CasinoMSR.Web.Data;
using CasinoMSR.Web.Interfaces;
using CasinoMSR.Web.logs;
using CasinoMSR.Web.Models;
using CasinoMSR.Web.Repositories;
using CasinoMSR.Web.signalR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CasinoMSR.Web
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
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<GameContext>(options =>
                options.UseSqlServer(connection));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<GameContext>()
                .AddDefaultTokenProviders();

            services.AddRazorPages();

            services.AddTransient<IEmailService, EmailService>();

            services.AddTransient<IGetGame, GameRepository>();

            services.AddScoped<IGetFavorite, FavoriteRepository>();

            services.AddSingleton<IEmailConfiguration>(new EmailConfiguration
            {
                SmtpServer = Configuration["EmailConfiguration:SmtpServer"],
                SmtpPort = int.Parse(Configuration["EmailConfiguration:SmtpPort"]),
                SmtpUsername = Configuration["EmailConfiguration:SmtpUsername"],
                SmtpPassword = Configuration["EmailConfiguration:SmtpPassword"]
            });

            

            services.AddControllersWithViews();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            //компоненты конвейера, которые отвечают за обработку запроса, называются middleware

            if (env.IsDevelopment())  
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();          //перенаправляет все запросы HTTP на HTTPS
            app.UseStaticFiles();           //предоставляет поддержку обработки статических файлов

            app.UseRouting();                   // Компонент маршрутизации

            app.UseAuthentication();                //поддержка аутентификации
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>               //отправляет ответ, если запрос пришел по маршруту
            {
                //Метод Map применяется для сопоставления пути запроса с определенным делегатом, который будет обрабатывать запрос по этому пути
                endpoints.MapHub<GameOnlineHub>("/gameonline");
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });

            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), Configuration.GetSection("AllLog").Value),
                Path.Combine(Directory.GetCurrentDirectory(), Configuration.GetSection("ErrorLog").Value));
            var logger = loggerFactory.CreateLogger("FileLogger");
        }


    }
}
