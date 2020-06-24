using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Stokpas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShProducts",
                columns: table => new
                {
                    sh_product_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shop_id = table.Column<int>(nullable: false),
                    product_url = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    original_price = table.Column<float>(nullable: false),
                    comment_count = table.Column<int>(nullable: false),
                    package_length = table.Column<int>(nullable: false),
                    package_width = table.Column<int>(nullable: false),
                    package_height = table.Column<int>(nullable: false),
                    is_pre_order = table.Column<bool>(nullable: false),
                    discount_id = table.Column<int>(nullable: false),
                    warning = table.Column<string>(nullable: true),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    modified_on = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShProducts", x => x.sh_product_id);
                });

            migrationBuilder.CreateTable(
                name: "TpCategorys",
                columns: table => new
                {
                    tp_category_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<int>(nullable: false),
                    category_name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TpCategorys", x => x.tp_category_id);
                });

            migrationBuilder.CreateTable(
                name: "TpProducts",
                columns: table => new
                {
                    tp_product_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shop_id = table.Column<int>(nullable: false),
                    product_url = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    product_short_description = table.Column<string>(nullable: true),
                    min_order = table.Column<int>(nullable: false),
                    etalase = table.Column<string>(nullable: false),
                    is_must_insurance = table.Column<bool>(nullable: false),
                    is_free_return = table.Column<bool>(nullable: false),
                    is_eligible_cod = table.Column<bool>(nullable: false),
                    weight_unit = table.Column<string>(nullable: false),
                    review_count = table.Column<int>(nullable: false),
                    transaction_success = table.Column<int>(nullable: false),
                    transaction_reject = table.Column<int>(nullable: false),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    modified_on = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TpProducts", x => x.tp_product_id);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    attribute_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    attribute_name = table.Column<string>(nullable: false),
                    is_mandatory = table.Column<bool>(nullable: false),
                    attribute_type = table.Column<string>(nullable: true),
                    attribute_value = table.Column<string>(nullable: true),
                    internal_option = table.Column<string>(nullable: true),
                    options = table.Column<string[]>(nullable: true),
                    ShProductssh_product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.attribute_id);
                    table.ForeignKey(
                        name: "FK_Attributes_ShProducts_ShProductssh_product_id",
                        column: x => x.ShProductssh_product_id,
                        principalTable: "ShProducts",
                        principalColumn: "sh_product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logistics",
                columns: table => new
                {
                    logistic_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    logistic_name = table.Column<string>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    shipping_fee = table.Column<float>(nullable: false),
                    is_free = table.Column<bool>(nullable: false),
                    ShProductssh_product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logistics", x => x.logistic_id);
                    table.ForeignKey(
                        name: "FK_Logistics_ShProducts_ShProductssh_product_id",
                        column: x => x.ShProductssh_product_id,
                        principalTable: "ShProducts",
                        principalColumn: "sh_product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShCategorys",
                columns: table => new
                {
                    sh_category_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<int>(nullable: false),
                    category_name = table.Column<string>(nullable: false),
                    has_children = table.Column<bool>(nullable: false),
                    sh_product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShCategorys", x => x.sh_category_id);
                    table.ForeignKey(
                        name: "FK_ShCategorys_ShProducts_sh_product_id",
                        column: x => x.sh_product_id,
                        principalTable: "ShProducts",
                        principalColumn: "sh_product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_sku = table.Column<int>(nullable: false),
                    product_name = table.Column<string>(nullable: false),
                    product_description = table.Column<string>(nullable: false),
                    currency = table.Column<string>(nullable: true),
                    condition = table.Column<string>(nullable: false),
                    has_variation = table.Column<bool>(nullable: false),
                    price = table.Column<float>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    weight = table.Column<int>(nullable: false),
                    rating_star = table.Column<int>(nullable: false),
                    sales = table.Column<int>(nullable: false),
                    view = table.Column<int>(nullable: false),
                    like = table.Column<int>(nullable: false),
                    days_to_ship = table.Column<int>(nullable: false),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    modified_on = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    tp_product_id = table.Column<int>(nullable: true),
                    sh_product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Products_ShProducts_sh_product_id",
                        column: x => x.sh_product_id,
                        principalTable: "ShProducts",
                        principalColumn: "sh_product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TpProducts_tp_product_id",
                        column: x => x.tp_product_id,
                        principalTable: "TpProducts",
                        principalColumn: "tp_product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    warehouse_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    price = table.Column<float>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    TpProductstp_product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.warehouse_id);
                    table.ForeignKey(
                        name: "FK_Warehouses_TpProducts_TpProductstp_product_id",
                        column: x => x.TpProductstp_product_id,
                        principalTable: "TpProducts",
                        principalColumn: "tp_product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    image_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    image_file_path = table.Column<string>(nullable: false),
                    image_file_name = table.Column<string>(nullable: true),
                    image_description = table.Column<string>(nullable: true),
                    Productsproduct_id = table.Column<int>(nullable: true),
                    ShProductssh_product_id = table.Column<int>(nullable: true),
                    TpProductstp_product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_Images_Products_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_ShProducts_ShProductssh_product_id",
                        column: x => x.ShProductssh_product_id,
                        principalTable: "ShProducts",
                        principalColumn: "sh_product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_TpProducts_TpProductstp_product_id",
                        column: x => x.TpProductstp_product_id,
                        principalTable: "TpProducts",
                        principalColumn: "tp_product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TierVariants",
                columns: table => new
                {
                    tier_variant_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tier_variant_name = table.Column<string>(nullable: false),
                    position = table.Column<int>(nullable: false),
                    Productsproduct_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TierVariants", x => x.tier_variant_id);
                    table.ForeignKey(
                        name: "FK_TierVariants_Products_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VariantModels",
                columns: table => new
                {
                    variant_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    price = table.Column<float>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    variant_sku = table.Column<string>(nullable: true),
                    internal_tier_index = table.Column<string>(nullable: true),
                    tier_index = table.Column<double[]>(nullable: true),
                    original_price = table.Column<float>(nullable: false),
                    discount_id = table.Column<int>(nullable: false),
                    Productsproduct_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantModels", x => x.variant_id);
                    table.ForeignKey(
                        name: "FK_VariantModels_Products_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wholesales",
                columns: table => new
                {
                    wholesale_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    min = table.Column<int>(nullable: false),
                    max = table.Column<int>(nullable: false),
                    unit_price = table.Column<float>(nullable: false),
                    Productsproduct_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wholesales", x => x.wholesale_id);
                    table.ForeignKey(
                        name: "FK_Wholesales_Products_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VariantOptions",
                columns: table => new
                {
                    variant_option_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    variant_option_name = table.Column<string>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    hex = table.Column<string>(nullable: true),
                    TierVariantstier_variant_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantOptions", x => x.variant_option_id);
                    table.ForeignKey(
                        name: "FK_VariantOptions_TierVariants_TierVariantstier_variant_id",
                        column: x => x.TierVariantstier_variant_id,
                        principalTable: "TierVariants",
                        principalColumn: "tier_variant_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_ShProductssh_product_id",
                table: "Attributes",
                column: "ShProductssh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Productsproduct_id",
                table: "Images",
                column: "Productsproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ShProductssh_product_id",
                table: "Images",
                column: "ShProductssh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_TpProductstp_product_id",
                table: "Images",
                column: "TpProductstp_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShProductssh_product_id",
                table: "Logistics",
                column: "ShProductssh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_sh_product_id",
                table: "Products",
                column: "sh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_tp_product_id",
                table: "Products",
                column: "tp_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShCategorys_sh_product_id",
                table: "ShCategorys",
                column: "sh_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_TierVariants_Productsproduct_id",
                table: "TierVariants",
                column: "Productsproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_VariantModels_Productsproduct_id",
                table: "VariantModels",
                column: "Productsproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_VariantOptions_TierVariantstier_variant_id",
                table: "VariantOptions",
                column: "TierVariantstier_variant_id");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_TpProductstp_product_id",
                table: "Warehouses",
                column: "TpProductstp_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Wholesales_Productsproduct_id",
                table: "Wholesales",
                column: "Productsproduct_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Logistics");

            migrationBuilder.DropTable(
                name: "ShCategorys");

            migrationBuilder.DropTable(
                name: "TpCategorys");

            migrationBuilder.DropTable(
                name: "VariantModels");

            migrationBuilder.DropTable(
                name: "VariantOptions");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Wholesales");

            migrationBuilder.DropTable(
                name: "TierVariants");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShProducts");

            migrationBuilder.DropTable(
                name: "TpProducts");
        }
    }
}
