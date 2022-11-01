using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_v28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleProducts_PRODUCT_ProductId",
                table: "SaleProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleProducts_SALE_SaleId",
                table: "SaleProducts");

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "SaleProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "SaleProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "TongTien",
                table: "ORDER_DETAIL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ORDER",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleProducts_PRODUCT_ProductId",
                table: "SaleProducts",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleProducts_SALE_SaleId",
                table: "SaleProducts",
                column: "SaleId",
                principalTable: "SALE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleProducts_PRODUCT_ProductId",
                table: "SaleProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleProducts_SALE_SaleId",
                table: "SaleProducts");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "ORDER_DETAIL");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ORDER");

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "SaleProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "SaleProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleProducts_PRODUCT_ProductId",
                table: "SaleProducts",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleProducts_SALE_SaleId",
                table: "SaleProducts",
                column: "SaleId",
                principalTable: "SALE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
