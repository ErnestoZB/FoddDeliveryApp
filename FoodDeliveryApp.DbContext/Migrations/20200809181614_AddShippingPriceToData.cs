using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.Db.Context.Migrations
{
    public partial class AddShippingPriceToData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "ShippingPrice",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "ShippingPrice",
                value: 27.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "ShippingPrice",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "ShippingPrice",
                value: 0.0);
        }
    }
}
