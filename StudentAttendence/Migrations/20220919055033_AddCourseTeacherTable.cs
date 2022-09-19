using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddCourseTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseTeachers",
                columns: table => new
                {
                    CSSSID = table.Column<int>(type: "int", nullable: false),
                    TTTTTId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTeachers", x => new { x.CSSSID, x.TTTTTId });
                    table.ForeignKey(
                        name: "FK_CourseTeachers_csss_CSSSID",
                        column: x => x.CSSSID,
                        principalTable: "csss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTeachers_tttt_TTTTTId",
                        column: x => x.TTTTTId,
                        principalTable: "tttt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeachers_TTTTTId",
                table: "CourseTeachers",
                column: "TTTTTId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTeachers");
        }
    }
}
