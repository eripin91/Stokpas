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
                name: "ShCategorys",
                columns: table => new
                {
                    sh_category_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<int>(nullable: false),
                    category_name = table.Column<string>(nullable: false),
                    has_children = table.Column<bool>(nullable: false),
                    request_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShCategorys", x => x.sh_category_id);
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
                name: "Product",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shop_id = table.Column<int>(nullable: false),
                    product_url = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    product_sku = table.Column<int>(nullable: false),
                    product_name = table.Column<string>(nullable: false),
                    product_description = table.Column<string>(nullable: false),
                    product_short_description = table.Column<string>(nullable: true),
                    min_order = table.Column<int>(nullable: false),
                    etalase = table.Column<string>(nullable: false),
                    is_must_insurance = table.Column<bool>(nullable: false),
                    is_free_return = table.Column<bool>(nullable: false),
                    is_eligible_cod = table.Column<bool>(nullable: false),
                    currency = table.Column<string>(nullable: true),
                    condition = table.Column<string>(nullable: false),
                    has_variation = table.Column<bool>(nullable: false),
                    price = table.Column<float>(nullable: false),
                    original_price = table.Column<float>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    weight = table.Column<int>(nullable: false),
                    weight_unit = table.Column<string>(nullable: false),
                    timestamp = table.Column<long>(nullable: false),
                    rating_star = table.Column<int>(nullable: false),
                    comment_count = table.Column<int>(nullable: false),
                    review_count = table.Column<int>(nullable: false),
                    transaction_success = table.Column<int>(nullable: false),
                    transaction_reject = table.Column<int>(nullable: false),
                    sales = table.Column<int>(nullable: false),
                    view = table.Column<int>(nullable: false),
                    like = table.Column<int>(nullable: false),
                    package_length = table.Column<int>(nullable: false),
                    package_width = table.Column<int>(nullable: false),
                    package_height = table.Column<int>(nullable: false),
                    is_pre_order = table.Column<bool>(nullable: false),
                    days_to_ship = table.Column<int>(nullable: false),
                    discount_id = table.Column<int>(nullable: false),
                    warning = table.Column<string>(nullable: true),
                    tp_category_id = table.Column<int>(nullable: false),
                    sh_category_id = table.Column<int>(nullable: false),
                    created_on = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    modified_on = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    request_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Product_ShCategorys_sh_category_id",
                        column: x => x.sh_category_id,
                        principalTable: "ShCategorys",
                        principalColumn: "sh_category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_TpCategorys_tp_category_id",
                        column: x => x.tp_category_id,
                        principalTable: "TpCategorys",
                        principalColumn: "tp_category_id",
                        onDelete: ReferentialAction.Cascade);
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
                    request_id = table.Column<string>(nullable: true),
                    Productsproduct_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_Images_Product_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Product",
                        principalColumn: "product_id",
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
                    request_id = table.Column<string>(nullable: true),
                    Productsproduct_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logistics", x => x.logistic_id);
                    table.ForeignKey(
                        name: "FK_Logistics_Product_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Product",
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
                        name: "FK_Wholesales_Product_Productsproduct_id",
                        column: x => x.Productsproduct_id,
                        principalTable: "Product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_Productsproduct_id",
                table: "Images",
                column: "Productsproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_Productsproduct_id",
                table: "Logistics",
                column: "Productsproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_sh_category_id",
                table: "Product",
                column: "sh_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_tp_category_id",
                table: "Product",
                column: "tp_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Wholesales_Productsproduct_id",
                table: "Wholesales",
                column: "Productsproduct_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Logistics");

            migrationBuilder.DropTable(
                name: "Wholesales");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ShCategorys");

            migrationBuilder.DropTable(
                name: "TpCategorys");
        }
    }
}
