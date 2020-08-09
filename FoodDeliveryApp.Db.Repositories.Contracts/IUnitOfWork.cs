using FoodDeliveryApp.Entities;

namespace FoodDeliveryApp.Db.Repositories.Contracts
{
    public interface IUnitOfWork
    {
        IBaseRepository<Dish> Dishes { get; }

        IBaseRepository<FoodCategory> FoodCategories { get; }

        IBaseRepository<Menu> Menus { get; }

        IBaseRepository<MenuCategory> MenuCategories { get; }

        IBaseRepository<Order> Orders { get; }

        IBaseRepository<Restaurant> Restaurants { get; }

        IBaseRepository<Score> Scores { get; }

        IBaseRepository<User> Users { get; }

        bool Commit();
    }
}
