﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JShope.Migrations
{
    public partial class Specifications3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Specifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Specifications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
