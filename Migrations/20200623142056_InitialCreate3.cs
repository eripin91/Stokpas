using Microsoft.EntityFrameworkCore.Migrations;

namespace Stokpas.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TpProducts_ShCategorys_sh_category_id",
                table: "TpProducts");

            migrationBuilder.DropIndex(
                name: "IX_TpProducts_sh_category_id",
                table: "TpProducts");

            migrationBuilder.DropColumn(
                name: "sh_category_id",
                table: "TpProducts");

            migrationBuilder.AddColumn<int>(
                name: "tp_category_id",
                table: "TpProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TpProducts_tp_category_id",
                table: "TpProducts",
                column: "tp_category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TpProducts_TpCategorys_tp_category_id",
                table: "TpProducts",
                column: "tp_category_id",
                principalTable: "TpCategorys",
                principalColumn: "tp_category_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TpProducts_TpCategorys_tp_category_id",
                table: "TpProducts");

            migrationBuilder.DropIndex(
                name: "IX_TpProducts_tp_category_id",
                table: "TpProducts");

            migrationBuilder.DropColumn(
                name: "tp_category_id",
                table: "TpProducts");

            migrationBuilder.AddColumn<int>(
                name: "sh_category_id",
                table: "TpProducts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TpProducts_sh_category_id",
                table: "TpProducts",
                column: "sh_category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TpProducts_ShCategorys_sh_category_id",
                table: "TpProducts",
                column: "sh_category_id",
                principalTable: "ShCategorys",
                principalColumn: "sh_category_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
