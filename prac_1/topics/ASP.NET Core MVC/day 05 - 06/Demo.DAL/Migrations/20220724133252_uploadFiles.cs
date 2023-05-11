using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DAL.Migrations
{
    public partial class uploadFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CVName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Employees");
        }
    }
}
