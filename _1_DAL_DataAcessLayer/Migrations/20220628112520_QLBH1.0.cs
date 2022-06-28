using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COLOR",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorCode = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COLOR", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "JOB",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    KeyWord = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOB", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "PRICE",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRICE", x => x.PriceId);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "SIZE",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIZE", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    ThuongHieuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THUONGHIEU", x => x.ThuongHieuId);
                });

            migrationBuilder.CreateTable(
                name: "TYPE",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYPE", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "USER_DETAIL",
                columns: table => new
                {
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_DETAIL", x => x.UserDetailId);
                });

            migrationBuilder.CreateTable(
                name: "IMAGE",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProducId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGE", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_IMAGE_PRODUCT_ProductId",
                        column: x => x.ProductId,
                        principalTable: "PRODUCT",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORIGIN",
                columns: table => new
                {
                    OriginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiSanXuat = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NamPhatHanh = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThuongHieuid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORIGIN", x => x.OriginId);
                    table.ForeignKey(
                        name: "FK_ORIGIN_THUONGHIEU_ThuongHieuid",
                        column: x => x.ThuongHieuid,
                        principalTable: "THUONGHIEU",
                        principalColumn: "ThuongHieuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    JodId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_USER_JOB_JobId",
                        column: x => x.JobId,
                        principalTable: "JOB",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USER_USER_DETAIL_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "USER_DETAIL",
                        principalColumn: "UserDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_DETAIL",
                columns: table => new
                {
                    ProductDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    QrCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Ver = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ChatLieu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false),
                    OriginId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_DETAIL", x => x.ProductDetailId);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_COLOR_ColorId",
                        column: x => x.ColorId,
                        principalTable: "COLOR",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_ORIGIN_OriginId",
                        column: x => x.OriginId,
                        principalTable: "ORIGIN",
                        principalColumn: "OriginId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_PRICE_PriceId",
                        column: x => x.PriceId,
                        principalTable: "PRICE",
                        principalColumn: "PriceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_SIZE_SizeId",
                        column: x => x.SizeId,
                        principalTable: "SIZE",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCT_DETAIL_TYPE_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TYPE",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ACCOUNT",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_ACCOUNT_USER_UserId1",
                        column: x => x.UserId1,
                        principalTable: "USER",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_ORDER_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "USER",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDER_DETAIL",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_DETAIL", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAIL_ORDER_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ORDER",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAIL_PRODUCT_ProductId",
                        column: x => x.ProductId,
                        principalTable: "PRODUCT",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_UserId1",
                table: "ACCOUNT",
                column: "UserId1");

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
                name: "IX_PRODUCT_DETAIL_ColorId",
                table: "PRODUCT_DETAIL",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_OriginId",
                table: "PRODUCT_DETAIL",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_PriceId",
                table: "PRODUCT_DETAIL",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_SizeId",
                table: "PRODUCT_DETAIL",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_DETAIL_TypeId",
                table: "PRODUCT_DETAIL",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_USER_JobId",
                table: "USER",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_USER_UserDetailId",
                table: "USER",
                column: "UserDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "IMAGE");

            migrationBuilder.DropTable(
                name: "ORDER_DETAIL");

            migrationBuilder.DropTable(
                name: "PRODUCT_DETAIL");

            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "COLOR");

            migrationBuilder.DropTable(
                name: "ORIGIN");

            migrationBuilder.DropTable(
                name: "PRICE");

            migrationBuilder.DropTable(
                name: "SIZE");

            migrationBuilder.DropTable(
                name: "TYPE");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "JOB");

            migrationBuilder.DropTable(
                name: "USER_DETAIL");
        }
    }
}
