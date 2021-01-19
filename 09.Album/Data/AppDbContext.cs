using _09.Album.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace _09.Album.Data
{
    // Kế thừa từ IdentityDbContext nên có sẵn các DbSet
    // UserRoles Roles RoleClaimsUsers UserClaims UserLogins UserTokens
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            // tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            // Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            builder.Model.GetEntityTypes().ToList()
                .ForEach(e =>
                {
                    var tableName = e.GetTableName();
                    if (tableName.StartsWith("AspNet"))
                    {
                        e.SetTableName(tableName.Substring(6));
                    }
                });
        }
    }
}
