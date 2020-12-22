using Microsoft.EntityFrameworkCore.Migrations;

namespace _07.EF01.Migrations.School
{
    public partial class manytomanyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddress",
                table: "StudentAddress");

            migrationBuilder.RenameTable(
                name: "StudentAddress",
                newName: "StudentAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAddress_StudentId",
                table: "StudentAddresses",
                newName: "IX_StudentAddresses_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses",
                column: "StudentAddressId");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddresses_Students_StudentId",
                table: "StudentAddresses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddresses_Students_StudentId",
                table: "StudentAddresses");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses");

            migrationBuilder.RenameTable(
                name: "StudentAddresses",
                newName: "StudentAddress");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAddresses_StudentId",
                table: "StudentAddress",
                newName: "IX_StudentAddress_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddress",
                table: "StudentAddress",
                column: "StudentAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
