using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PRODUCT",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PRODUCT",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105,
                oldNullable: true);
        }
    }
}
