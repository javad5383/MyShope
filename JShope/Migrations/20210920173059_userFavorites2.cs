using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class userFavorites2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UserFavorites_UserFavoritesFavoritesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_UserFavoritesFavoritesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserFavoritesFavoritesId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "UserFavorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_ProductId",
                table: "UserFavorites",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorites_Products_ProductId",
                table: "UserFavorites",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_Products_ProductId",
                table: "UserFavorites");

            migrationBuilder.DropIndex(
                name: "IX_UserFavorites_ProductId",
                table: "UserFavorites");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "UserFavorites");

            migrationBuilder.AddColumn<int>(
                name: "UserFavoritesFavoritesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserFavoritesFavoritesId",
                table: "Products",
                column: "UserFavoritesFavoritesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UserFavorites_UserFavoritesFavoritesId",
                table: "Products",
                column: "UserFavoritesFavoritesId",
                principalTable: "UserFavorites",
                principalColumn: "FavoritesId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
