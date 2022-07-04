using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App1.Migrations
{
    public partial class addNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 17, 15, 49, 851, DateTimeKind.Local).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 15, 33, 28, 12, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", maxLength: 40, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 15, 33, 28, 12, DateTimeKind.Local).AddTicks(9933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 17, 15, 49, 851, DateTimeKind.Local).AddTicks(275));
        }
    }
}
