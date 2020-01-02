using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWebApp.Migrations
{
    public partial class UsernamePasswordRegistrationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "User",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "User",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "User",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
