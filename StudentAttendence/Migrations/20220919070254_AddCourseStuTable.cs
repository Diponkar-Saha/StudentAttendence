using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddCourseStuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseStu",
                columns: table => new
                {
                    CSSSID = table.Column<int>(type: "int", nullable: false),
                    SSSId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStu", x => new { x.CSSSID, x.SSSId });
                    table.ForeignKey(
                        name: "FK_CourseStu_csss_CSSSID",
                        column: x => x.CSSSID,
                        principalTable: "csss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStu_ssss_SSSId",
                        column: x => x.SSSId,
                        principalTable: "ssss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStu_SSSId",
                table: "CourseStu",
                column: "SSSId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStu");
        }
    }
}
