using _07.EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace _07.EF01.Context
{
    public class BloggingContext : DbContext
    {
        readonly string connectionString = @"
                Data Source=CTY-LTP-702;
                Initial Catalog=EF01;
                User ID=SA;Password=1234$#@!qwer";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
