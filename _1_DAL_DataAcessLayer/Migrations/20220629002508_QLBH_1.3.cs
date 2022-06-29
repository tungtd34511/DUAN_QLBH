using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserDetailId",
                table: "USER_DETAIL",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "USER",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "TYPE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ThuongHieuId",
                table: "THUONGHIEU",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "SIZE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "PRODUCT",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PriceId",
                table: "PRICE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OriginId",
                table: "ORIGIN",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderDetailId",
                table: "ORDER_DETAIL",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ORDER",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "JOB",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "IMAGE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "COLOR",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "ACCOUNT",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "USER_DETAIL",
                newName: "UserDetailId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "USER",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TYPE",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "THUONGHIEU",
                newName: "ThuongHieuId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SIZE",
                newName: "SizeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PRODUCT",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PRICE",
                newName: "PriceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ORIGIN",
                newName: "OriginId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ORDER_DETAIL",
                newName: "OrderDetailId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ORDER",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JOB",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IMAGE",
                newName: "ImageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "COLOR",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ACCOUNT",
                newName: "AccountId");
        }
    }
}
