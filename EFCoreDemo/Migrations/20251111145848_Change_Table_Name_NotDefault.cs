using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class Change_Table_Name_NotDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeTable");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                table: "EmployeeTable",
                newName: "IX_EmployeeTable_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTable",
                table: "EmployeeTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_Department_DepartmentId",
                table: "EmployeeTable",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_Department_DepartmentId",
                table: "EmployeeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTable",
                table: "EmployeeTable");

            migrationBuilder.RenameTable(
                name: "EmployeeTable",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTable_DepartmentId",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
