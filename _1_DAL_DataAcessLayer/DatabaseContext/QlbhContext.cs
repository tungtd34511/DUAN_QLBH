using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAcessLayer.DatabaseContext
{
    public class QLBHContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Khi cấu hình đường dẫn nếu chưa có DB thì có thể đặt tên DB ở đây
                optionsBuilder
                    .UseSqlServer(
                        "Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=QLBH_DU_AN_1_;Integrated Security=True");
            }
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityHistory> ActivityHistories { get; set; }
        public DbSet<Catergory> Catergories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Role> Rolls { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ThuongHieu> ThuongHieus{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Ver> Vers { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }
        //EF CODE FIRST
        //1. CÀI ĐẶT:
        //+ Install-Package Microsoft.EntityFrameworkCore
        //+ Install-Package Microsoft.EntityFrameworkCore.SqlServer
        //+ Install-Package Microsoft.EntityFrameworkCore.Tools
        //2. Tạo lớp các đối tượng Model cần có trong dự án trong thư mục Models:
        //+ Các lớp đối tượng này chính là các bảng sẽ được tạo trong CSDl
        //+ Xem lại cách cấu hình trong model ở project
        //3. Tạo 1 lớp DBContext trong thư mục DBContext:
        //+ Xem cấu hình ở bên trong file DBContextDungna
        //4. Tiến hành tạo Database thông qua câu lệnh trong PM
        //+ add-migration<Tên phiên bản>
        //+ update-database thực thi tiến hành zen vào DB
        //Lứu ý: 
        //+ Toàn bộ các project không được phép có lỗi đỏ
        //+ Copy đường dẫn nhanh ko copy từ đường dẫn bên ngoài.
        //+ Đặt tên DB mới tùy ý
    }
}
