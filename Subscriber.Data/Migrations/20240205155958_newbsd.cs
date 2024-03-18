using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Subscriber.Data.Migrations
{
    /// <inheritdoc />
    public partial class newbsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TZ",
                table: "Subscriber",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Subscriber",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TZ",
                table: "Subscriber",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Subscriber",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);
        }
    }
}
