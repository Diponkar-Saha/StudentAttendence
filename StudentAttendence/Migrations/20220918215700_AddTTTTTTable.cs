using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddTTTTTTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TTTTTId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tttt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tttt", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TTTTTId",
                table: "Users",
                column: "TTTTTId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_tttt_TTTTTId",
                table: "Users",
                column: "TTTTTId",
                principalTable: "tttt",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_tttt_TTTTTId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "tttt");

            migrationBuilder.DropIndex(
                name: "IX_Users_TTTTTId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TTTTTId",
                table: "Users");
        }
    }
}
