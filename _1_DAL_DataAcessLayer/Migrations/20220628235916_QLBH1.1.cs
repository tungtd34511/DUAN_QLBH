using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_ProductId",
                table: "PRODUCT_DETAIL",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_PRODUCT_ProductId",
                table: "PRODUCT_DETAIL",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_PRODUCT_ProductId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCT_DETAIL_ProductId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PRODUCT_DETAIL");
        }
    }
}
