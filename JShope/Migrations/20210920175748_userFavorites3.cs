using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class userFavorites3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserFavorites_ProductId",
                table: "UserFavorites");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_ProductId",
                table: "UserFavorites",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserFavorites_ProductId",
                table: "UserFavorites");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_ProductId",
                table: "UserFavorites",
                column: "ProductId",
                unique: true);
        }
    }
}
