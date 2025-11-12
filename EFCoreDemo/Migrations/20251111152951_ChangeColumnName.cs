using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "HR",
                table: "EmployeeTable",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "HR",
                table: "EmployeeTable",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "HR",
                table: "EmployeeTable",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "HR",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
