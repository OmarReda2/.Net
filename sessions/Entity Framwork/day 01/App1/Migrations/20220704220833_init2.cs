using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App1.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_DepartementsDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartementsDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartementsDeptId",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 5, 0, 8, 33, 72, DateTimeKind.Local).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 5, 0, 4, 54, 922, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.CreateTable(
                name: "DepartementEmployee",
                columns: table => new
                {
                    DepartementsDeptId = table.Column<int>(type: "int", nullable: false),
                    EmployeesEmpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartementEmployee", x => new { x.DepartementsDeptId, x.EmployeesEmpId });
                    table.ForeignKey(
                        name: "FK_DepartementEmployee_Departements_DepartementsDeptId",
                        column: x => x.DepartementsDeptId,
                        principalTable: "Departements",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartementEmployee_Employees_EmployeesEmpId",
                        column: x => x.EmployeesEmpId,
                        principalTable: "Employees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartementEmployee_EmployeesEmpId",
                table: "DepartementEmployee",
                column: "EmployeesEmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartementEmployee");

            migrationBuilder.AddColumn<int>(
                name: "DepartementsDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfCreation",
                table: "Departements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 5, 0, 4, 54, 922, DateTimeKind.Local).AddTicks(9876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 5, 0, 8, 33, 72, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartementsDeptId",
                table: "Employees",
                column: "DepartementsDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_DepartementsDeptId",
                table: "Employees",
                column: "DepartementsDeptId",
                principalTable: "Departements",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
