using _07.EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace _07.EF01.Context
{
    public class ProductsContext : DbContext
    {
        // Thuộc tính products kiểu DbSet<Product> cho biết CSDL có bảng mà
        // thông tin về bảng dữ liệu biểu diễn bởi model Product
        public DbSet<Product> products { set; get; }
        // Chuỗi kết nối tới CSDL (MS SQL Server)
        private const string connectionString = @"
                Data Source=CTY-LTP-702;
                Initial Catalog=EF01;
                User ID=SA;Password=1234$#@!qwer";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
