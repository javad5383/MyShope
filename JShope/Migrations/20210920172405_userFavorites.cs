using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class userFavorites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserFavoritesFavoritesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserFavorites",
                columns: table => new
                {
                    FavoritesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavorites", x => x.FavoritesId);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserFavoritesFavoritesId",
                table: "Products",
                column: "UserFavoritesFavoritesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_UserId",
                table: "UserFavorites",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UserFavorites_UserFavoritesFavoritesId",
                table: "Products",
                column: "UserFavoritesFavoritesId",
                principalTable: "UserFavorites",
                principalColumn: "FavoritesId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UserFavorites_UserFavoritesFavoritesId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "UserFavorites");

            migrationBuilder.DropIndex(
                name: "IX_Products_UserFavoritesFavoritesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserFavoritesFavoritesId",
                table: "Products");
        }
    }
}
