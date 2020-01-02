using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWebApp.Migrations
{
    public partial class fieldstypesupdatetovarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "User",
                type: "VARCHAR(10)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "User",
                type: "VARCHAR(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "User",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)",
                oldNullable: true);
        }
    }
}
