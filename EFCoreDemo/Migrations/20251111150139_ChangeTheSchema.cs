using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTheSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.RenameTable(
                name: "EmployeeTable",
                newName: "EmployeeTable",
                newSchema: "HR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EmployeeTable",
                schema: "HR",
                newName: "EmployeeTable");
        }
    }
}
