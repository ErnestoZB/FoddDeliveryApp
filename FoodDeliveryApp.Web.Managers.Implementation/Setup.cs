using FoodDeliveryApp.Models;
using FoodDeliveryApp.Web.Managers.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public static class Setup
    {
        public static void AddManagers(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseManager<Restaurant>), typeof(RestaurantManager));
            services.AddTransient(typeof(IBaseManager<Menu>), typeof(MenuManager));
            services.AddTransient(typeof(IBaseManager<FoodCategory>), typeof(FoodCategoryManager));
            services.AddTransient(typeof(IMapper), typeof(Mapper));
        }
    }
}
