using LHBLL;
using LHDAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
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
            //services.RegisterBLLServices();
            #region BLL Services
            services.AddTransient<ICategoryBL, CategoryBL>();
            services.AddTransient<IURLsBL, URLsBL>();
            services.AddTransient<IUserBL, UserBL>();
            //Dependency Injection package creats an object of CategoryBL class and injects it to CategoryController ctor 
            #endregion


            #region DAL Services
            services.AddTransient<ICategoryDb, CategoryDb>();
            services.AddTransient<IURLsDb, URLsDb>();
            services.AddTransient<IUserDb, UserDb>(); 
            #endregion

            services.AddDbContext<LHDBContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("LHConString")));
            services.AddRazorPages();
            services.AddMvc();
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                //endpoints.MapRazorPages();
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
