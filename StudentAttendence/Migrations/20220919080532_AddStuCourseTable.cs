using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddStuCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "CourseStudent");

            migrationBuilder.CreateTable(
                name: "CourseStudd",
                columns: table => new
                {
                    CSSSID = table.Column<int>(type: "int", nullable: false),
                    SSSId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudd", x => new { x.CSSSID, x.SSSId });
                    table.ForeignKey(
                        name: "FK_CourseStudd_csss_CSSSID",
                        column: x => x.CSSSID,
                        principalTable: "csss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudd_ssss_SSSId",
                        column: x => x.SSSId,
                        principalTable: "ssss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StuCourses",
                columns: table => new
                {
                    CSSSID = table.Column<int>(type: "int", nullable: false),
                    SSSId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    sSSSId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StuCourses", x => new { x.CSSSID, x.SSSId });
                    table.ForeignKey(
                        name: "FK_StuCourses_csss_CSSSID",
                        column: x => x.CSSSID,
                        principalTable: "csss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StuCourses_vvvvv_sSSSId",
                        column: x => x.sSSSId,
                        principalTable: "vvvvv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudd_SSSId",
                table: "CourseStudd",
                column: "SSSId");

            migrationBuilder.CreateIndex(
                name: "IX_StuCourses_sSSSId",
                table: "StuCourses",
                column: "sSSSId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudd");

            migrationBuilder.DropTable(
                name: "StuCourses");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CourseStudent",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
