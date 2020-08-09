using FoodDeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp.Db.Context.Configuration
{
    static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory
                {
                    FoodCategoryId = 1,
                    Type = "Burger",
                    Icon = "https://i.postimg.cc/Hcm3TwyX/burger.png"
                });

            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory
                {
                    FoodCategoryId = 2,
                    Type = "Dessert",
                    Icon = "https://i.postimg.cc/S2GdRn65/dessert.png"
                });

            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory
                {
                    FoodCategoryId = 3,
                    Type = "Pizza",
                    Icon = "https://i.postimg.cc/zHXjgqpf/pizza.png"
                });


            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    RestaurantId = 1,
                    Name = "Burger State",
                    Image = "https://i.postimg.cc/cCNLMfNm/option3.png",
                    MinDeliveryTime = 15,
                    MaxDeliveryTime = 25,
                    ShippingPrice = 30,
                    Address = "ALDAMA NO. 3315, OBRERA, 31000",
                    FoodCategoryId = 1,
                });

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Millonario State Cafe",
                    Image = "https://i.postimg.cc/NMZjpN65/option1.png",
                    MinDeliveryTime = 30,
                    MaxDeliveryTime = 45,
                    ShippingPrice = 27,
                    Address = "ALDAMA NO. 3315, OBRERA, 31000",
                    FoodCategoryId = 1,
                });

            modelBuilder.Entity<Score>().HasData(
                new Score
                {
                    ScoreId = 1,
                    Count = 100,
                    Average = 4.3,
                    RestaurantId = 1
                });


            modelBuilder.Entity<Score>().HasData(
                new Score
                {
                    ScoreId = 2,
                    Count = 87,
                    Average = 4.8,
                    RestaurantId = 2
                });

            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    MenuId = 1,
                    RestaurantId = 1
                });

            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory
                {
                    MenuCategoryId = 1,
                    Name = "Comidas",
                    MenuId = 1
                });

            modelBuilder.Entity<MenuCategory>().HasData(
                new MenuCategory
                {
                    MenuCategoryId = 2,
                    Name = "Bebidas",
                    MenuId = 1
                });

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 1,
                    Name = "Hamburguesa con queso",
                    Description = "Incluye papas",
                    Price = 50,
                    MenuCategoryId = 1
                });

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 2,
                    Name = "Hamburguesa con doble carne",
                    Description = "Incluye papas",
                    Price = 70,
                    MenuCategoryId = 1
                });

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 3,
                    Name = "Agua de limón",
                    Description = "500ml",
                    Price = 20,
                    MenuCategoryId = 2
                });

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 4,
                    Name = "Agua de tamarindo",
                    Description = "500ml",
                    Price = 20,
                    MenuCategoryId = 2
                });
        }
    }
}