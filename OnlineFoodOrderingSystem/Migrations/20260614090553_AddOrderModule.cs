using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFoodOrderingSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "FoodItemId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemId",
                table: "OrderDetails",
                column: "FoodItemId",
                principalTable: "FoodItems",
                principalColumn: "FoodItemId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "FoodItemId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_FoodItems_FoodItemId",
                table: "OrderDetails",
                column: "FoodItemId",
                principalTable: "FoodItems",
                principalColumn: "FoodItemId");
        }
    }
}
