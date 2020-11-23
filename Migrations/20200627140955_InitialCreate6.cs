using Microsoft.EntityFrameworkCore.Migrations;

namespace Stokpas.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ShProducts_ShProductssh_product_id",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_TpProducts_TpProductstp_product_id",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Logistics_ShProducts_ShProductssh_product_id",
                table: "Logistics");

            migrationBuilder.DropForeignKey(
                name: "FK_TierVariants_Products_Productsproduct_id",
                table: "TierVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantModels_Products_Productsproduct_id",
                table: "VariantModels");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantOptions_TierVariants_TierVariantstier_variant_id",
                table: "VariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Wholesales_Products_Productsproduct_id",
                table: "Wholesales");

            migrationBuilder.DropIndex(
                name: "IX_VariantOptions_TierVariantstier_variant_id",
                table: "VariantOptions");

            migrationBuilder.DropIndex(
                name: "IX_Logistics_ShProductssh_product_id",
                table: "Logistics");

            migrationBuilder.DropIndex(
                name: "IX_Images_ShProductssh_product_id",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_TpProductstp_product_id",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "TierVariantstier_variant_id",
                table: "VariantOptions");

            migrationBuilder.DropColumn(
                name: "ShProductssh_product_id",
                table: "Logistics");

            migrationBuilder.DropColumn(
                name: "ShProductssh_product_id",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "TpProductstp_product_id",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Productsproduct_id",
                table: "Wholesales",
                newName: "productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_Wholesales_Productsproduct_id",
                table: "Wholesales",
                newName: "IX_Wholesales_productsproduct_id");

            migrationBuilder.RenameColumn(
                name: "Productsproduct_id",
                table: "VariantModels",
                newName: "productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_VariantModels_Productsproduct_id",
                table: "VariantModels",
                newName: "IX_VariantModels_productsproduct_id");

            migrationBuilder.RenameColumn(
                name: "Productsproduct_id",
                table: "TierVariants",
                newName: "productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_TierVariants_Productsproduct_id",
                table: "TierVariants",
                newName: "IX_TierVariants_productsproduct_id");

            migrationBuilder.AddColumn<int>(
                name: "tier_variantstier_variant_id",
                table: "VariantOptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sh_product_id",
                table: "Logistics",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sh_productssh_product_id",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tp_productstp_product_id",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VariantOptions_tier_variantstier_variant_id",
                table: "VariantOptions",
                column: "tier_variantstier_variant_id");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_sh_product_id",
                table: "Logistics",
                column: "sh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_sh_productssh_product_id",
                table: "Images",
                column: "sh_productssh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_tp_productstp_product_id",
                table: "Images",
                column: "tp_productstp_product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ShProducts_sh_productssh_product_id",
                table: "Images",
                column: "sh_productssh_product_id",
                principalTable: "ShProducts",
                principalColumn: "sh_product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_TpProducts_tp_productstp_product_id",
                table: "Images",
                column: "tp_productstp_product_id",
                principalTable: "TpProducts",
                principalColumn: "tp_product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logistics_ShProducts_sh_product_id",
                table: "Logistics",
                column: "sh_product_id",
                principalTable: "ShProducts",
                principalColumn: "sh_product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TierVariants_Products_productsproduct_id",
                table: "TierVariants",
                column: "productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantModels_Products_productsproduct_id",
                table: "VariantModels",
                column: "productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantOptions_TierVariants_tier_variantstier_variant_id",
                table: "VariantOptions",
                column: "tier_variantstier_variant_id",
                principalTable: "TierVariants",
                principalColumn: "tier_variant_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wholesales_Products_productsproduct_id",
                table: "Wholesales",
                column: "productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ShProducts_sh_productssh_product_id",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_TpProducts_tp_productstp_product_id",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Logistics_ShProducts_sh_product_id",
                table: "Logistics");

            migrationBuilder.DropForeignKey(
                name: "FK_TierVariants_Products_productsproduct_id",
                table: "TierVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantModels_Products_productsproduct_id",
                table: "VariantModels");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantOptions_TierVariants_tier_variantstier_variant_id",
                table: "VariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Wholesales_Products_productsproduct_id",
                table: "Wholesales");

            migrationBuilder.DropIndex(
                name: "IX_VariantOptions_tier_variantstier_variant_id",
                table: "VariantOptions");

            migrationBuilder.DropIndex(
                name: "IX_Logistics_sh_product_id",
                table: "Logistics");

            migrationBuilder.DropIndex(
                name: "IX_Images_sh_productssh_product_id",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_tp_productstp_product_id",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "tier_variantstier_variant_id",
                table: "VariantOptions");

            migrationBuilder.DropColumn(
                name: "sh_product_id",
                table: "Logistics");

            migrationBuilder.DropColumn(
                name: "sh_productssh_product_id",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "tp_productstp_product_id",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "productsproduct_id",
                table: "Wholesales",
                newName: "Productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_Wholesales_productsproduct_id",
                table: "Wholesales",
                newName: "IX_Wholesales_Productsproduct_id");

            migrationBuilder.RenameColumn(
                name: "productsproduct_id",
                table: "VariantModels",
                newName: "Productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_VariantModels_productsproduct_id",
                table: "VariantModels",
                newName: "IX_VariantModels_Productsproduct_id");

            migrationBuilder.RenameColumn(
                name: "productsproduct_id",
                table: "TierVariants",
                newName: "Productsproduct_id");

            migrationBuilder.RenameIndex(
                name: "IX_TierVariants_productsproduct_id",
                table: "TierVariants",
                newName: "IX_TierVariants_Productsproduct_id");

            migrationBuilder.AddColumn<int>(
                name: "TierVariantstier_variant_id",
                table: "VariantOptions",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShProductssh_product_id",
                table: "Logistics",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShProductssh_product_id",
                table: "Images",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TpProductstp_product_id",
                table: "Images",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VariantOptions_TierVariantstier_variant_id",
                table: "VariantOptions",
                column: "TierVariantstier_variant_id");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShProductssh_product_id",
                table: "Logistics",
                column: "ShProductssh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ShProductssh_product_id",
                table: "Images",
                column: "ShProductssh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_TpProductstp_product_id",
                table: "Images",
                column: "TpProductstp_product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ShProducts_ShProductssh_product_id",
                table: "Images",
                column: "ShProductssh_product_id",
                principalTable: "ShProducts",
                principalColumn: "sh_product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_TpProducts_TpProductstp_product_id",
                table: "Images",
                column: "TpProductstp_product_id",
                principalTable: "TpProducts",
                principalColumn: "tp_product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logistics_ShProducts_ShProductssh_product_id",
                table: "Logistics",
                column: "ShProductssh_product_id",
                principalTable: "ShProducts",
                principalColumn: "sh_product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TierVariants_Products_Productsproduct_id",
                table: "TierVariants",
                column: "Productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantModels_Products_Productsproduct_id",
                table: "VariantModels",
                column: "Productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantOptions_TierVariants_TierVariantstier_variant_id",
                table: "VariantOptions",
                column: "TierVariantstier_variant_id",
                principalTable: "TierVariants",
                principalColumn: "tier_variant_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wholesales_Products_Productsproduct_id",
                table: "Wholesales",
                column: "Productsproduct_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
