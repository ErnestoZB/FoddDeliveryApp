using FoodDeliveryApp.Db.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodDeliveryApp.Db.Context
{
    public static class Setup
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var foodDeliveryDatabase = configuration.GetConnectionString("FoodDeliveryDatabase");
            services.AddDbContext<FoodDeliveryContext>(o => o.UseSqlServer(foodDeliveryDatabase), ServiceLifetime.Transient);
        }
    }
}
