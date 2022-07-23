using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Finished",
                table: "SALE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Started",
                table: "SALE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "SALE");

            migrationBuilder.DropColumn(
                name: "Started",
                table: "SALE");
        }
    }
}
