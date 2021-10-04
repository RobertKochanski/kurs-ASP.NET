using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantAPI.Migrations
{
    public partial class RestaurantCreatedByIdAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CretedById",
                table: "Restaurants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CretedById",
                table: "Restaurants",
                column: "CretedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Users_CretedById",
                table: "Restaurants",
                column: "CretedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Users_CretedById",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_CretedById",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CretedById",
                table: "Restaurants");
        }
    }
}
