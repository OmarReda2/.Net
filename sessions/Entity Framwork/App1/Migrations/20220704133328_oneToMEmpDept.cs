using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App1.Migrations
{
    public partial class oneToMEmpDept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartementDeptId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 15, 33, 28, 12, DateTimeKind.Local).AddTicks(9933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 14, 24, 8, 74, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartementDeptId",
                table: "Employee",
                column: "DepartementDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departements_DepartementDeptId",
                table: "Employee",
                column: "DepartementDeptId",
                principalTable: "Departements",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departements_DepartementDeptId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartementDeptId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartementDeptId",
                table: "Employee");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 14, 24, 8, 74, DateTimeKind.Local).AddTicks(1356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 15, 33, 28, 12, DateTimeKind.Local).AddTicks(9933));
        }
    }
}
