using FoodDeliveryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace FoodDeliveryApp.DbContext
{
    public class FoodDeliveryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Score> Scores { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }


        public FoodDeliveryContext()
        {
        }

        public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();

                var connectionString = configuration.GetConnectionString("FoodDeliveryDatabase");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDish>()
                .HasKey(t => new { t.OrderId, t.DishId });

            modelBuilder.Entity<OrderDish>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.OrderDishes)
                .HasForeignKey(pt => pt.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDish>()
                .HasOne(pt => pt.Dish)
                .WithMany(t => t.OrderDishes)
                .HasForeignKey(pt => pt.DishId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RestaurantUser>()
                .HasKey(t => new { t.RestaurantId, t.UserId });

            modelBuilder.Entity<RestaurantUser>()
                .HasOne(pt => pt.Restaurant)
                .WithMany(p => p.Users)
                .HasForeignKey(pt => pt.RestaurantId);

            modelBuilder.Entity<RestaurantUser>()
                .HasOne(pt => pt.User)
                .WithMany(t => t.FavoriteRestaurants)
                .HasForeignKey(pt => pt.UserId);
        }
    }
}