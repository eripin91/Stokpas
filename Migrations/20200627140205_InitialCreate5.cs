using Microsoft.EntityFrameworkCore.Migrations;

namespace Stokpas.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_Productsproduct_id",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Productsproduct_id",
                table: "Images",
                newName: "productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_Images_Productsproduct_id",
                table: "Images",
                newName: "IX_Images_productsproduct_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_productsproduct_id",
                table: "Images",
                column: "productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_productsproduct_id",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "productsproduct_id",
                table: "Images",
                newName: "Productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_Images_productsproduct_id",
                table: "Images",
                newName: "IX_Images_Productsproduct_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_Productsproduct_id",
                table: "Images",
                column: "Productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
