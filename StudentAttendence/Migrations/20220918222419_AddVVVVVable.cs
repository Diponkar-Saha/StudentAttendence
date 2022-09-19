using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendence.Migrations
{
    public partial class AddVVVVVable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VVVVVId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "vvvvv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vvvvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vvvvv", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_VVVVVId",
                table: "Users",
                column: "VVVVVId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_vvvvv_VVVVVId",
                table: "Users",
                column: "VVVVVId",
                principalTable: "vvvvv",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_vvvvv_VVVVVId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "vvvvv");

            migrationBuilder.DropIndex(
                name: "IX_Users_VVVVVId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VVVVVId",
                table: "Users");
        }
    }
}
