using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class addSelectedProductColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SelectedProductColor",
                table: "CartDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedProductColor",
                table: "CartDetails");
        }
    }
}
