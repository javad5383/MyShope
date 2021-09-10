using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class OrderSeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SeenByAdmin",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeenByAdmin",
                table: "Orders");
        }
    }
}
