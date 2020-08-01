using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.Db.Repositories.Implementation;
using FoodDeliveryApp.DbContext;
using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using FoodDeliveryApp.Web.Managers.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FoodDeliveryApp.Web.Api
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
            services.AddControllers();

            var foodDeliveryDatabase = Configuration.GetConnectionString("FoodDeliveryDatabase");
            services.AddDbContext<FoodDeliveryContext>(o => o.UseSqlServer(foodDeliveryDatabase), ServiceLifetime.Transient);

            services.AddTransient(typeof(IBaseManager<Restaurant>), typeof(RestaurantManager));
            services.AddTransient(typeof(IBaseManager<Menu>), typeof(MenuManager));
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
