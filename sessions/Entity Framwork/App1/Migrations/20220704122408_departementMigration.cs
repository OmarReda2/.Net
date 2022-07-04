using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App1.Migrations
{
    public partial class departementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 7, 4, 14, 24, 8, 74, DateTimeKind.Local).AddTicks(1356))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.DeptId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departements");
        }
    }
}
