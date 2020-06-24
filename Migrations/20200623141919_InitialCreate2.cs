using Microsoft.EntityFrameworkCore.Migrations;

namespace Stokpas.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShCategorys_ShProducts_sh_product_id",
                table: "ShCategorys");

            migrationBuilder.DropIndex(
                name: "IX_ShCategorys_sh_product_id",
                table: "ShCategorys");

            migrationBuilder.DropColumn(
                name: "sh_product_id",
                table: "ShCategorys");

            migrationBuilder.AddColumn<int>(
                name: "sh_category_id",
                table: "TpProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sh_category_id",
                table: "ShProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TpProducts_sh_category_id",
                table: "TpProducts",
                column: "sh_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShProducts_sh_category_id",
                table: "ShProducts",
                column: "sh_category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShProducts_ShCategorys_sh_category_id",
                table: "ShProducts",
                column: "sh_category_id",
                principalTable: "ShCategorys",
                principalColumn: "sh_category_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TpProducts_ShCategorys_sh_category_id",
                table: "TpProducts",
                column: "sh_category_id",
                principalTable: "ShCategorys",
                principalColumn: "sh_category_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShProducts_ShCategorys_sh_category_id",
                table: "ShProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TpProducts_ShCategorys_sh_category_id",
                table: "TpProducts");

            migrationBuilder.DropIndex(
                name: "IX_TpProducts_sh_category_id",
                table: "TpProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShProducts_sh_category_id",
                table: "ShProducts");

            migrationBuilder.DropColumn(
                name: "sh_category_id",
                table: "TpProducts");

            migrationBuilder.DropColumn(
                name: "sh_category_id",
                table: "ShProducts");

            migrationBuilder.AddColumn<int>(
                name: "sh_product_id",
                table: "ShCategorys",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShCategorys_sh_product_id",
                table: "ShCategorys",
                column: "sh_product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShCategorys_ShProducts_sh_product_id",
                table: "ShCategorys",
                column: "sh_product_id",
                principalTable: "ShProducts",
                principalColumn: "sh_product_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
