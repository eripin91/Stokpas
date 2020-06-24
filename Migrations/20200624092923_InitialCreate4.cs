using Microsoft.EntityFrameworkCore.Migrations;

namespace Stokpas.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "like",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "like",
                table: "ShProducts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "like",
                table: "ShProducts");

            migrationBuilder.AddColumn<int>(
                name: "like",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
