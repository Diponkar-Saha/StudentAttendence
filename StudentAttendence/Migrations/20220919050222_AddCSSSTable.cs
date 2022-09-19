using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddCSSSTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CSSSId",
                table: "vvvvv",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CSSSId",
                table: "tttt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CSSSId",
                table: "classTimes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "csss",
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
                    table.PrimaryKey("PK_csss", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vvvvv_CSSSId",
                table: "vvvvv",
                column: "CSSSId");

            migrationBuilder.CreateIndex(
                name: "IX_tttt_CSSSId",
                table: "tttt",
                column: "CSSSId");

            migrationBuilder.CreateIndex(
                name: "IX_classTimes_CSSSId",
                table: "classTimes",
                column: "CSSSId");

            migrationBuilder.AddForeignKey(
                name: "FK_classTimes_csss_CSSSId",
                table: "classTimes",
                column: "CSSSId",
                principalTable: "csss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tttt_csss_CSSSId",
                table: "tttt",
                column: "CSSSId",
                principalTable: "csss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vvvvv_csss_CSSSId",
                table: "vvvvv",
                column: "CSSSId",
                principalTable: "csss",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classTimes_csss_CSSSId",
                table: "classTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_tttt_csss_CSSSId",
                table: "tttt");

            migrationBuilder.DropForeignKey(
                name: "FK_vvvvv_csss_CSSSId",
                table: "vvvvv");

            migrationBuilder.DropTable(
                name: "csss");

            migrationBuilder.DropIndex(
                name: "IX_vvvvv_CSSSId",
                table: "vvvvv");

            migrationBuilder.DropIndex(
                name: "IX_tttt_CSSSId",
                table: "tttt");

            migrationBuilder.DropIndex(
                name: "IX_classTimes_CSSSId",
                table: "classTimes");

            migrationBuilder.DropColumn(
                name: "CSSSId",
                table: "vvvvv");

            migrationBuilder.DropColumn(
                name: "CSSSId",
                table: "tttt");

            migrationBuilder.DropColumn(
                name: "CSSSId",
                table: "classTimes");
        }
    }
}
