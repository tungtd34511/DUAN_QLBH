using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_USER_UserId",
                table: "ACCOUNT");

            migrationBuilder.DropForeignKey(
                name: "FK_ACTIVITY_HISTORY_ACTIVITY_ActivityId",
                table: "ACTIVITY_HISTORY");

            migrationBuilder.DropForeignKey(
                name: "FK_ACTIVITY_HISTORY_USER_UserId",
                table: "ACTIVITY_HISTORY");

            migrationBuilder.DropForeignKey(
                name: "FK_IMAGE_PRODUCT_ProductId",
                table: "IMAGE");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_USER_UserId",
                table: "ORDER");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_DETAIL_ORDER_OrderId",
                table: "ORDER_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                table: "ORDER_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_ORIGIN_THUONGHIEU_ThuongHieuid",
                table: "ORIGIN");

            migrationBuilder.DropForeignKey(
                name: "FK_PRICE_SALE_SaleId",
                table: "PRICE");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_PRODUCT_DETAIL_ProductDetailId",
                table: "PRODUCT");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_CATERGORY_CatergoryId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_ORIGIN_OriginId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_PRICE_PriceId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_ROLL_JobId",
                table: "USER");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_USER_DETAIL_UserDetailId",
                table: "USER");

            migrationBuilder.DropForeignKey(
                name: "FK_VER_COLOR_ColorId",
                table: "VER");

            migrationBuilder.DropForeignKey(
                name: "FK_VER_PRODUCT_DETAIL_ProductDetailId",
                table: "VER");

            migrationBuilder.DropForeignKey(
                name: "FK_VER_SIZE_SizeId",
                table: "VER");

            migrationBuilder.DropColumn(
                name: "JodId",
                table: "USER");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "USER",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_USER_JobId",
                table: "USER",
                newName: "IX_USER_RoleId");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "VER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetailId",
                table: "VER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "VER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserDetailId",
                table: "USER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PriceId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OriginId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CatergoryId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetailId",
                table: "PRODUCT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "PRICE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ThuongHieuid",
                table: "ORIGIN",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ORDER_DETAIL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "ORDER_DETAIL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ORDER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VerId",
                table: "IMAGE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "IMAGE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "COLOR",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CATERGORY",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaNhomCha",
                table: "CATERGORY",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ACTIVITY_HISTORY",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "ACTIVITY_HISTORY",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ACCOUNT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ACCOUNT_USER_UserId",
                table: "ACCOUNT",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ACTIVITY_HISTORY_ACTIVITY_ActivityId",
                table: "ACTIVITY_HISTORY",
                column: "ActivityId",
                principalTable: "ACTIVITY",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ACTIVITY_HISTORY_USER_UserId",
                table: "ACTIVITY_HISTORY",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IMAGE_PRODUCT_ProductId",
                table: "IMAGE",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_USER_UserId",
                table: "ORDER",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_DETAIL_ORDER_OrderId",
                table: "ORDER_DETAIL",
                column: "OrderId",
                principalTable: "ORDER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                table: "ORDER_DETAIL",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORIGIN_THUONGHIEU_ThuongHieuid",
                table: "ORIGIN",
                column: "ThuongHieuid",
                principalTable: "THUONGHIEU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PRICE_SALE_SaleId",
                table: "PRICE",
                column: "SaleId",
                principalTable: "SALE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_PRODUCT_DETAIL_ProductDetailId",
                table: "PRODUCT",
                column: "ProductDetailId",
                principalTable: "PRODUCT_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_CATERGORY_CatergoryId",
                table: "PRODUCT_DETAIL",
                column: "CatergoryId",
                principalTable: "CATERGORY",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_ORIGIN_OriginId",
                table: "PRODUCT_DETAIL",
                column: "OriginId",
                principalTable: "ORIGIN",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_PRICE_PriceId",
                table: "PRODUCT_DETAIL",
                column: "PriceId",
                principalTable: "PRICE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_ROLL_RoleId",
                table: "USER",
                column: "RoleId",
                principalTable: "ROLL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_USER_DETAIL_UserDetailId",
                table: "USER",
                column: "UserDetailId",
                principalTable: "USER_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VER_COLOR_ColorId",
                table: "VER",
                column: "ColorId",
                principalTable: "COLOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VER_PRODUCT_DETAIL_ProductDetailId",
                table: "VER",
                column: "ProductDetailId",
                principalTable: "PRODUCT_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VER_SIZE_SizeId",
                table: "VER",
                column: "SizeId",
                principalTable: "SIZE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_USER_UserId",
                table: "ACCOUNT");

            migrationBuilder.DropForeignKey(
                name: "FK_ACTIVITY_HISTORY_ACTIVITY_ActivityId",
                table: "ACTIVITY_HISTORY");

            migrationBuilder.DropForeignKey(
                name: "FK_ACTIVITY_HISTORY_USER_UserId",
                table: "ACTIVITY_HISTORY");

            migrationBuilder.DropForeignKey(
                name: "FK_IMAGE_PRODUCT_ProductId",
                table: "IMAGE");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_USER_UserId",
                table: "ORDER");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_DETAIL_ORDER_OrderId",
                table: "ORDER_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                table: "ORDER_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_ORIGIN_THUONGHIEU_ThuongHieuid",
                table: "ORIGIN");

            migrationBuilder.DropForeignKey(
                name: "FK_PRICE_SALE_SaleId",
                table: "PRICE");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_PRODUCT_DETAIL_ProductDetailId",
                table: "PRODUCT");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_CATERGORY_CatergoryId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_ORIGIN_OriginId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCT_DETAIL_PRICE_PriceId",
                table: "PRODUCT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_ROLL_RoleId",
                table: "USER");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_USER_DETAIL_UserDetailId",
                table: "USER");

            migrationBuilder.DropForeignKey(
                name: "FK_VER_COLOR_ColorId",
                table: "VER");

            migrationBuilder.DropForeignKey(
                name: "FK_VER_PRODUCT_DETAIL_ProductDetailId",
                table: "VER");

            migrationBuilder.DropForeignKey(
                name: "FK_VER_SIZE_SizeId",
                table: "VER");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "USER",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_USER_RoleId",
                table: "USER",
                newName: "IX_USER_JobId");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "VER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetailId",
                table: "VER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "VER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserDetailId",
                table: "USER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JodId",
                table: "USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PriceId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OriginId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatergoryId",
                table: "PRODUCT_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetailId",
                table: "PRODUCT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SaleId",
                table: "PRICE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ThuongHieuid",
                table: "ORIGIN",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ORDER_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "ORDER_DETAIL",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ORDER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VerId",
                table: "IMAGE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "IMAGE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "COLOR",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "CATERGORY",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaNhomCha",
                table: "CATERGORY",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ACTIVITY_HISTORY",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "ACTIVITY_HISTORY",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ACCOUNT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ACCOUNT_USER_UserId",
                table: "ACCOUNT",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ACTIVITY_HISTORY_ACTIVITY_ActivityId",
                table: "ACTIVITY_HISTORY",
                column: "ActivityId",
                principalTable: "ACTIVITY",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ACTIVITY_HISTORY_USER_UserId",
                table: "ACTIVITY_HISTORY",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IMAGE_PRODUCT_ProductId",
                table: "IMAGE",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_USER_UserId",
                table: "ORDER",
                column: "UserId",
                principalTable: "USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_DETAIL_ORDER_OrderId",
                table: "ORDER_DETAIL",
                column: "OrderId",
                principalTable: "ORDER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                table: "ORDER_DETAIL",
                column: "ProductId",
                principalTable: "PRODUCT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORIGIN_THUONGHIEU_ThuongHieuid",
                table: "ORIGIN",
                column: "ThuongHieuid",
                principalTable: "THUONGHIEU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRICE_SALE_SaleId",
                table: "PRICE",
                column: "SaleId",
                principalTable: "SALE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_PRODUCT_DETAIL_ProductDetailId",
                table: "PRODUCT",
                column: "ProductDetailId",
                principalTable: "PRODUCT_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_CATERGORY_CatergoryId",
                table: "PRODUCT_DETAIL",
                column: "CatergoryId",
                principalTable: "CATERGORY",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_ORIGIN_OriginId",
                table: "PRODUCT_DETAIL",
                column: "OriginId",
                principalTable: "ORIGIN",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCT_DETAIL_PRICE_PriceId",
                table: "PRODUCT_DETAIL",
                column: "PriceId",
                principalTable: "PRICE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_ROLL_JobId",
                table: "USER",
                column: "JobId",
                principalTable: "ROLL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_USER_DETAIL_UserDetailId",
                table: "USER",
                column: "UserDetailId",
                principalTable: "USER_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VER_COLOR_ColorId",
                table: "VER",
                column: "ColorId",
                principalTable: "COLOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VER_PRODUCT_DETAIL_ProductDetailId",
                table: "VER",
                column: "ProductDetailId",
                principalTable: "PRODUCT_DETAIL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VER_SIZE_SizeId",
                table: "VER",
                column: "SizeId",
                principalTable: "SIZE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
