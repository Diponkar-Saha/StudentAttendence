using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddClassScheduleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CSSSID = table.Column<int>(type: "int", nullable: false),
                    ToTalClass = table.Column<int>(type: "int", nullable: false),
                    Weekday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    endTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_classSchedules_csss_CSSSID",
                        column: x => x.CSSSID,
                        principalTable: "csss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classSchedules_CSSSID",
                table: "classSchedules",
                column: "CSSSID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classSchedules");
        }
    }
}
