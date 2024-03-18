using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Subscriber.Data.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardTablecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    OpenDate = table.Column<DateTime>(type: "date", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    height = table.Column<double>(type: "float", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTablecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriber", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTablecs");

            migrationBuilder.DropTable(
                name: "Subscriber");
        }
    }
}
