﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_DataAcessLayer.DatabaseContext;

namespace _1_DAL_DataAcessLayer.Migrations
{
    [DbContext(typeof(QLBHContext))]
    [Migration("20220717075118_QLBH_1.8")]
    partial class QLBH_18
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Acc")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Pass")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ACCOUNT");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ACTIVITY");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ActivityHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("ACTIVITY_HISTORY");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Catergory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MaNhomCha")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CATERGORY");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColorCode")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("COLOR");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("VerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("IMAGE");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ORDER");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ORDER_DETAIL");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Origin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NamPhatHanh")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiSanXuat")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int?>("ThuongHieuid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThuongHieuid");

                    b.ToTable("ORIGIN");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("PRICE");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(105)
                        .HasColumnType("nvarchar(105)");

                    b.Property<int?>("ProductDetailId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductDetailId");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CatergoryId")
                        .HasColumnType("int");

                    b.Property<string>("ChatLieu")
                        .HasMaxLength(505)
                        .HasColumnType("nvarchar(505)");

                    b.Property<string>("MoTaChiTiet")
                        .HasMaxLength(505)
                        .HasColumnType("nvarchar(505)");

                    b.Property<int?>("OriginId")
                        .HasColumnType("int");

                    b.Property<int?>("PriceId")
                        .HasColumnType("int");

                    b.Property<string>("QrCode")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CatergoryId");

                    b.HasIndex("OriginId");

                    b.HasIndex("PriceId");

                    b.ToTable("PRODUCT_DETAIL");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Key")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ROLL");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("SalePercent")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SALE");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SIZE");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ThuongHieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("THUONGHIEU");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("UserDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserDetailId");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Image")
                        .HasMaxLength(305)
                        .HasColumnType("nvarchar(305)");

                    b.Property<string>("Note")
                        .HasMaxLength(305)
                        .HasColumnType("nvarchar(305)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("USER_DETAIL");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Ver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductDetailId")
                        .HasColumnType("int");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("SizeId");

                    b.ToTable("VER");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Account", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ActivityHistory", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Image", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Order", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.OrderDetail", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Origin", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.ThuongHieu", "ThuongHieu")
                        .WithMany()
                        .HasForeignKey("ThuongHieuid");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Price", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Product", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetailId");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ProductDetail", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Catergory", "Catergory")
                        .WithMany()
                        .HasForeignKey("CatergoryId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Origin", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.Navigation("Catergory");

                    b.Navigation("Origin");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.User", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.UserDetail", "UserDetail")
                        .WithMany()
                        .HasForeignKey("UserDetailId");

                    b.Navigation("Role");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Ver", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetailId");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("Color");

                    b.Navigation("ProductDetail");

                    b.Navigation("Size");
                });
#pragma warning restore 612, 618
        }
    }
}
