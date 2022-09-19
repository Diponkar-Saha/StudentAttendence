using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddCCCCTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classTimes_Course_CourseId",
                table: "classTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_CourseId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Course_CourseId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "courses");

            migrationBuilder.AddColumn<int>(
                name: "CCCCId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CCCCId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CCCCId",
                table: "classTimes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "cccc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseFees = table.Column<int>(type: "int", nullable: false),
                    CCCCId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cccc", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CCCCId",
                table: "Teachers",
                column: "CCCCId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CCCCId",
                table: "Student",
                column: "CCCCId");

            migrationBuilder.CreateIndex(
                name: "IX_classTimes_CCCCId",
                table: "classTimes",
                column: "CCCCId");

            migrationBuilder.AddForeignKey(
                name: "FK_classTimes_cccc_CCCCId",
                table: "classTimes",
                column: "CCCCId",
                principalTable: "cccc",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_classTimes_courses_CourseId",
                table: "classTimes",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_cccc_CCCCId",
                table: "Student",
                column: "CCCCId",
                principalTable: "cccc",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_courses_CourseId",
                table: "Student",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_cccc_CCCCId",
                table: "Teachers",
                column: "CCCCId",
                principalTable: "cccc",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_courses_CourseId",
                table: "Teachers",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classTimes_cccc_CCCCId",
                table: "classTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_classTimes_courses_CourseId",
                table: "classTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_cccc_CCCCId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_courses_CourseId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_cccc_CCCCId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_courses_CourseId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "cccc");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CCCCId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Student_CCCCId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_classTimes_CCCCId",
                table: "classTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CCCCId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CCCCId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CCCCId",
                table: "classTimes");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_classTimes_Course_CourseId",
                table: "classTimes",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_CourseId",
                table: "Student",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Course_CourseId",
                table: "Teachers",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }
    }
}
