using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class AddDeliveryAddressTocart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryAddress",
                table: "Carts");
        }
    }
}
