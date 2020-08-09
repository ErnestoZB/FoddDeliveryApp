using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.Db.Context.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Icon", "Type" },
                values: new object[] { 1, "https://i.postimg.cc/Hcm3TwyX/burger.png", "Burger" });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Icon", "Type" },
                values: new object[] { 2, "https://i.postimg.cc/S2GdRn65/dessert.png", "Dessert" });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Icon", "Type" },
                values: new object[] { 3, "https://i.postimg.cc/zHXjgqpf/pizza.png", "Pizza" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "FoodCategoryId", "Image", "MaxDeliveryTime", "MinDeliveryTime", "Name", "ShippingPrice" },
                values: new object[] { 1, "ALDAMA NO. 3315, OBRERA, 31000", 1, "https://i.postimg.cc/cCNLMfNm/option3.png", 25, 15, "Burger State", 0.0 });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "FoodCategoryId", "Image", "MaxDeliveryTime", "MinDeliveryTime", "Name", "ShippingPrice" },
                values: new object[] { 2, "ALDAMA NO. 3315, OBRERA, 31000", 1, "https://i.postimg.cc/NMZjpN65/option1.png", 45, 30, "Millonario State Cafe", 0.0 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "RestaurantId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreId", "Average", "Count", "RestaurantId" },
                values: new object[] { 1, 4.2999999999999998, 100, 1 });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreId", "Average", "Count", "RestaurantId" },
                values: new object[] { 2, 4.7999999999999998, 87, 2 });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "MenuCategoryId", "MenuId", "Name" },
                values: new object[] { 1, 1, "Comidas" });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "MenuCategoryId", "MenuId", "Name" },
                values: new object[] { 2, 1, "Bebidas" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Description", "Image", "MenuCategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Incluye papas", null, 1, "Hamburguesa con queso", 50.0 },
                    { 2, "Incluye papas", null, 1, "Hamburguesa con doble carne", 70.0 },
                    { 3, "500ml", null, 2, "Agua de limón", 20.0 },
                    { 4, "500ml", null, 2, "Agua de tamarindo", 20.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "ScoreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "MenuCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "MenuCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 1);
        }
    }
}
