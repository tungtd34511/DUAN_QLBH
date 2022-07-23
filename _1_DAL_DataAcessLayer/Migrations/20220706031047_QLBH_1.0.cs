using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACTIVITY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CATERGORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    MaNhomCha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATERGORY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COLOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COLOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROLL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    SalePercent = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIZE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIZE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THUONGHIEU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USER_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(305)", maxLength: 305, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(305)", maxLength: 305, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_DETAIL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRICE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRICE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRICE_SALE_SaleId",
                        column: x => x.SaleId,
                        principalTable: "SALE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORIGIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiSanXuat = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    NamPhatHanh = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThuongHieuid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORIGIN", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORIGIN_THUONGHIEU_ThuongHieuid",
                        column: x => x.ThuongHieuid,
                        principalTable: "THUONGHIEU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    JodId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                    table.ForeignKey(
                        name: "FK_USER_ROLL_JobId",
                        column: x => x.JobId,
                        principalTable: "ROLL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USER_USER_DETAIL_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "USER_DETAIL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QrCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ChatLieu = table.Column<string>(type: "nvarchar(505)", maxLength: 505, nullable: true),
                    MoTaChiTiet = table.Column<string>(type: "nvarchar(505)", maxLength: 505, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CatergoryId = table.Column<int>(type: "int", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false),
                    OriginId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_DETAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_CATERGORY_CatergoryId",
                        column: x => x.CatergoryId,
                        principalTable: "CATERGORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_ORIGIN_OriginId",
                        column: x => x.OriginId,
                        principalTable: "ORIGIN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_PRICE_PriceId",
                        column: x => x.PriceId,
                        principalTable: "PRICE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ACCOUNT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ACCOUNT_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ACTIVITY_HISTORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACTIVITY_HISTORY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ACTIVITY_HISTORY_ACTIVITY_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "ACTIVITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ACTIVITY_HISTORY_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDER_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProductDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUCT_PRODUCT_DETAIL_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "PRODUCT_DETAIL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    ProductDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VER", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VER_COLOR_ColorId",
                        column: x => x.ColorId,
                        principalTable: "COLOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VER_PRODUCT_DETAIL_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "PRODUCT_DETAIL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VER_SIZE_SizeId",
                        column: x => x.SizeId,
                        principalTable: "SIZE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IMAGE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IMAGE_PRODUCT_ProductId",
                        column: x => x.ProductId,
                        principalTable: "PRODUCT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDER_DETAIL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_DETAIL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAIL_ORDER_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ORDER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                        column: x => x.ProductId,
                        principalTable: "PRODUCT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_UserId",
                table: "ACCOUNT",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ACTIVITY_HISTORY_ActivityId",
                table: "ACTIVITY_HISTORY",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ACTIVITY_HISTORY_UserId",
                table: "ACTIVITY_HISTORY",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IMAGE_ProductId",
                table: "IMAGE",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_UserId",
                table: "ORDER",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAIL_OrderId",
                table: "ORDER_DETAIL",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAIL_ProductId",
                table: "ORDER_DETAIL",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ORIGIN_ThuongHieuid",
                table: "ORIGIN",
                column: "ThuongHieuid");

            migrationBuilder.CreateIndex(
                name: "IX_PRICE_SaleId",
                table: "PRICE",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_ProductDetailId",
                table: "PRODUCT",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_CatergoryId",
                table: "PRODUCT_DETAIL",
                column: "CatergoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_OriginId",
                table: "PRODUCT_DETAIL",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_PriceId",
                table: "PRODUCT_DETAIL",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_USER_JobId",
                table: "USER",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_USER_UserDetailId",
                table: "USER",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_VER_ColorId",
                table: "VER",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_VER_ProductDetailId",
                table: "VER",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_VER_SizeId",
                table: "VER",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "ACTIVITY_HISTORY");

            migrationBuilder.DropTable(
                name: "IMAGE");

            migrationBuilder.DropTable(
                name: "ORDER_DETAIL");

            migrationBuilder.DropTable(
                name: "VER");

            migrationBuilder.DropTable(
                name: "ACTIVITY");

            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "COLOR");

            migrationBuilder.DropTable(
                name: "SIZE");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "PRODUCT_DETAIL");

            migrationBuilder.DropTable(
                name: "ROLL");

            migrationBuilder.DropTable(
                name: "USER_DETAIL");

            migrationBuilder.DropTable(
                name: "CATERGORY");

            migrationBuilder.DropTable(
                name: "ORIGIN");

            migrationBuilder.DropTable(
                name: "PRICE");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "SALE");
        }
    }
}
