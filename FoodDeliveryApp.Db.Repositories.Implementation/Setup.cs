using FoodDeliveryApp.Db.Repositories.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace FoodDeliveryApp.Db.Repositories.Implementation
{
    public static class Setup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}