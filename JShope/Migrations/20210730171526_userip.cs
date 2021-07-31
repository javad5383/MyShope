using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class userip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserIP",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserIP",
                table: "Users");
        }
    }
}
