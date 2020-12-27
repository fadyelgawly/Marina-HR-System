using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using MarinaHR.Data;
using MarinaHR.Models;
using MarinaHR.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.HttpsPolicy;
using Hangfire;
using Hangfire.SQLite;
using Hangfire.Dashboard;
using Hangfire.EntityFrameworkCore;
using MarinaHR.Services;


namespace MarinaHR
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
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, UserRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();
            services.Configure<IdentityOptions>(options => {
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;

            });
            services.AddControllersWithViews();
            services.AddRazorPages();
            
            services.AddTransient<MarinaHR.Services.ISalaryManager, MarinaHR.Services.SalaryManager>();

            var connectionString = Configuration.GetConnectionString("HangfireConnection");
            services.AddHangfire(configuration =>
                configuration.UseEFCoreStorage(builder =>
                    builder.UseSqlite(connectionString),
                    new EFCoreStorageOptions
                    {
                        CountersAggregationInterval = new TimeSpan(0, 5, 0),
                        DistributedLockTimeout = new TimeSpan(0, 10, 0),
                        JobExpirationCheckInterval = new TimeSpan(0, 30, 0),
                        QueuePollInterval = new TimeSpan(0, 0, 15),
                        Schema = string.Empty,
                        SlidingInvisibilityTimeout = new TimeSpan(0, 5, 0),
                    }).
                UseDatabaseCreator());

            services.AddHangfireServer();
            services.AddMvc();

            //services.AddSingleton<ISingleton, Singleton>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IBackgroundJobClient backgroundJobs, IWebHostEnvironment env, ISalaryManager salaryManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseHangfireDashboard();

            RecurringJob.AddOrUpdate(
                () => salaryManager.ReleaseWeeklySalaries(),
                "*/5 * * * * *");

            RecurringJob.AddOrUpdate(
                () => salaryManager.ReleaseMonthlySalaries(),
                "*/20 * * * * *");


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHangfireDashboard();
            });


        }
    }
}
