using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class addBirthDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                schema: "HR",
                table: "EmployeeTable");

            migrationBuilder.AddColumn<DateOnly>(
                name: "BirthDay",
                schema: "HR",
                table: "EmployeeTable",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                schema: "HR",
                table: "EmployeeTable");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "HR",
                table: "EmployeeTable",
                type: "int",
                nullable: true);
        }
    }
}
