using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_v25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                table: "ORDER_DETAIL");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "ORDER_DETAIL");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ORDER_DETAIL",
                newName: "VerId");

            migrationBuilder.RenameIndex(
                name: "IX_ORDER_DETAIL_ProductId",
                table: "ORDER_DETAIL",
                newName: "IX_ORDER_DETAIL_VerId");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "ORDER",
                newName: "Created");

            migrationBuilder.AddColumn<int>(
                name: "KhachHangId",
                table: "ORDER",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TongTien",
                table: "ORDER",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_KhachHangId",
                table: "ORDER",
                column: "KhachHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_KhachHang_KhachHangId",
                table: "ORDER",
                column: "KhachHangId",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_DETAIL_VER_VerId",
                table: "ORDER_DETAIL",
                column: "VerId",
                principalTable: "VER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_KhachHang_KhachHangId",
                table: "ORDER");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_DETAIL_VER_VerId",
                table: "ORDER_DETAIL");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropIndex(
                name: "IX_ORDER_KhachHangId",
                table: "ORDER");

            migrationBuilder.DropColumn(
                name: "KhachHangId",
                table: "ORDER");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "ORDER");

            migrationBuilder.RenameColumn(
                name: "VerId",
                table: "ORDER_DETAIL",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ORDER_DETAIL_VerId",
                table: "ORDER_DETAIL",
                newName: "IX_ORDER_DETAIL_ProductId");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "ORDER",
                newName: "Time");

            migrationBuilder.AddColumn<decimal>(
                name: "TongTien",
                table: "ORDER_DETAIL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                table: "ORDER_DETAIL",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
