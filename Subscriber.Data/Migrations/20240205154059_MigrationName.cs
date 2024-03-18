using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Subscriber.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TZ",
                table: "Subscriber",
                type: "int",
                maxLength: 9,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TZ",
                table: "Subscriber");
        }
    }
}
