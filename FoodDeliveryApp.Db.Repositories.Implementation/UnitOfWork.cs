using FoodDeliveryApp.Db.Repositories.Contracts;
using FoodDeliveryApp.DbContext;
using FoodDeliveryApp.Models;
using System;

namespace FoodDeliveryApp.Db.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FoodDeliveryContext _context;

        public IBaseRepository<Dish> Dishes { get; }

        public IBaseRepository<FoodCategory> FoodCategories { get; }

        public IBaseRepository<Menu> Menus { get; }

        public IBaseRepository<MenuCategory> MenuCategories { get; }

        public IBaseRepository<Order> Orders { get; }

        public IBaseRepository<Restaurant> Restaurants { get;  }

        public IBaseRepository<Score> Scores { get; }

        public IBaseRepository<User> Users { get; }

        public UnitOfWork(FoodDeliveryContext context)
        {
            _context = context;

            Dishes = new BaseRepository<Dish>(_context);
            FoodCategories = new BaseRepository<FoodCategory>(_context);
            Menus = new MenuRepository(_context);
            MenuCategories = new BaseRepository<MenuCategory>(_context);
            Orders = new BaseRepository<Order>(_context);
            Restaurants = new BaseRepository<Restaurant>(_context);
            Scores = new BaseRepository<Score>(_context);
            Users = new BaseRepository<User>(_context);
        }

        public bool Commit()
        {
            try
            {
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}