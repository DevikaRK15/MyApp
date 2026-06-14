using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFoodOrderingSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemFoodId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "FoodItems");

            migrationBuilder.RenameColumn(
                name: "FoodItemFoodId",
                table: "OrderDetails",
                newName: "FoodItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_FoodItemFoodId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_FoodItemId");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "FoodItems",
                newName: "FoodItemId");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemId",
                table: "OrderDetails",
                column: "FoodItemId",
                principalTable: "FoodItems",
                principalColumn: "FoodItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FoodItems");

            migrationBuilder.RenameColumn(
                name: "FoodItemId",
                table: "OrderDetails",
                newName: "FoodItemFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_FoodItemId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_FoodItemFoodId");

            migrationBuilder.RenameColumn(
                name: "FoodItemId",
                table: "FoodItems",
                newName: "FoodId");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "FoodItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemFoodId",
                table: "OrderDetails",
                column: "FoodItemFoodId",
                principalTable: "FoodItems",
                principalColumn: "FoodId");
        }
    }
}
