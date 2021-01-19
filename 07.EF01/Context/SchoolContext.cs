using _07.EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace _07.EF01.Context
{
    public class SchoolContext : DbContext
    {
        // Thuộc tính products kiểu DbSet<Product> cho biết CSDL có bảng mà
        // thông tin về bảng dữ liệu biểu diễn bởi model Product
        public DbSet<Student> Students { set; get; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        // Chuỗi kết nối tới CSDL (MS SQL Server)
        private const string connectionString = @"
                Data Source=CTY-LTP-702;Initial Catalog=EF01;User ID=SA;Password=1234$#@!qwer";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<Student>()
                .HasOne<Grade>(g => g.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.CurrentGradeId);
            modelBuilder.Entity<Student>()
                .HasOne<StudentAddress>(s => s.Address)
                .WithOne(ad => ad.Student)
                .HasForeignKey<StudentAddress>(ad => ad.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Student>(s => s.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne<Course>(c => c.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(f => f.CourseId);
        }
    }
}
