using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "COLOR");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "COLOR",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "COLOR");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "COLOR",
                type: "int",
                nullable: true);
        }
    }
}
