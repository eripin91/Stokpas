﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Stokpas.Data;

namespace Stokpas.Migrations
{
    [DbContext(typeof(StokpasContext))]
    [Migration("20200627140205_InitialCreate5")]
    partial class InitialCreate5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Stokpas.Models.Attributes", b =>
                {
                    b.Property<int>("attribute_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ShProductssh_product_id")
                        .HasColumnType("integer");

                    b.Property<string>("attribute_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("attribute_type")
                        .HasColumnType("text");

                    b.Property<string>("attribute_value")
                        .HasColumnType("text");

                    b.Property<string>("internal_option")
                        .HasColumnType("text");

                    b.Property<bool>("is_mandatory")
                        .HasColumnType("boolean");

                    b.Property<string[]>("options")
                        .HasColumnType("text[]");

                    b.HasKey("attribute_id");

                    b.HasIndex("ShProductssh_product_id");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("Stokpas.Models.Images", b =>
                {
                    b.Property<int>("image_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ShProductssh_product_id")
                        .HasColumnType("integer");

                    b.Property<int?>("TpProductstp_product_id")
                        .HasColumnType("integer");

                    b.Property<string>("image_description")
                        .HasColumnType("text");

                    b.Property<string>("image_file_name")
                        .HasColumnType("text");

                    b.Property<string>("image_file_path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("productsproduct_id")
                        .HasColumnType("integer");

                    b.HasKey("image_id");

                    b.HasIndex("ShProductssh_product_id");

                    b.HasIndex("TpProductstp_product_id");

                    b.HasIndex("productsproduct_id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Stokpas.Models.Logistics", b =>
                {
                    b.Property<int>("logistic_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ShProductssh_product_id")
                        .HasColumnType("integer");

                    b.Property<bool>("is_free")
                        .HasColumnType("boolean");

                    b.Property<string>("logistic_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("shipping_fee")
                        .HasColumnType("real");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("logistic_id");

                    b.HasIndex("ShProductssh_product_id");

                    b.ToTable("Logistics");
                });

            modelBuilder.Entity("Stokpas.Models.Products", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("condition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("created_by")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("currency")
                        .HasColumnType("text");

                    b.Property<int>("days_to_ship")
                        .HasColumnType("integer");

                    b.Property<bool>("has_variation")
                        .HasColumnType("boolean");

                    b.Property<string>("modified_by")
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_on")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("product_description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_sku")
                        .HasColumnType("integer");

                    b.Property<int>("rating_star")
                        .HasColumnType("integer");

                    b.Property<int>("sales")
                        .HasColumnType("integer");

                    b.Property<int?>("sh_product_id")
                        .HasColumnType("integer");

                    b.Property<int>("stock")
                        .HasColumnType("integer");

                    b.Property<int?>("tp_product_id")
                        .HasColumnType("integer");

                    b.Property<int>("view")
                        .HasColumnType("integer");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.HasKey("product_id");

                    b.HasIndex("sh_product_id");

                    b.HasIndex("tp_product_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Stokpas.Models.ShCategorys", b =>
                {
                    b.Property<int>("sh_category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("has_children")
                        .HasColumnType("boolean");

                    b.Property<int>("parent_id")
                        .HasColumnType("integer");

                    b.HasKey("sh_category_id");

                    b.ToTable("ShCategorys");
                });

            modelBuilder.Entity("Stokpas.Models.ShProducts", b =>
                {
                    b.Property<int>("sh_product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("comment_count")
                        .HasColumnType("integer");

                    b.Property<string>("created_by")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("discount_id")
                        .HasColumnType("integer");

                    b.Property<bool>("is_pre_order")
                        .HasColumnType("boolean");

                    b.Property<int>("like")
                        .HasColumnType("integer");

                    b.Property<string>("modified_by")
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_on")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("original_price")
                        .HasColumnType("real");

                    b.Property<int>("package_height")
                        .HasColumnType("integer");

                    b.Property<int>("package_length")
                        .HasColumnType("integer");

                    b.Property<int>("package_width")
                        .HasColumnType("integer");

                    b.Property<string>("product_url")
                        .HasColumnType("text");

                    b.Property<int?>("sh_category_id")
                        .HasColumnType("integer");

                    b.Property<int>("shop_id")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<string>("warning")
                        .HasColumnType("text");

                    b.HasKey("sh_product_id");

                    b.HasIndex("sh_category_id");

                    b.ToTable("ShProducts");
                });

            modelBuilder.Entity("Stokpas.Models.TierVariants", b =>
                {
                    b.Property<int>("tier_variant_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Productsproduct_id")
                        .HasColumnType("integer");

                    b.Property<int>("position")
                        .HasColumnType("integer");

                    b.Property<string>("tier_variant_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("tier_variant_id");

                    b.HasIndex("Productsproduct_id");

                    b.ToTable("TierVariants");
                });

            modelBuilder.Entity("Stokpas.Models.TpCategorys", b =>
                {
                    b.Property<int>("tp_category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("parent_id")
                        .HasColumnType("integer");

                    b.HasKey("tp_category_id");

                    b.ToTable("TpCategorys");
                });

            modelBuilder.Entity("Stokpas.Models.TpProducts", b =>
                {
                    b.Property<int>("tp_product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("created_by")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("etalase")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("is_eligible_cod")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_free_return")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_must_insurance")
                        .HasColumnType("boolean");

                    b.Property<int>("min_order")
                        .HasColumnType("integer");

                    b.Property<string>("modified_by")
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_on")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("product_short_description")
                        .HasColumnType("text");

                    b.Property<string>("product_url")
                        .HasColumnType("text");

                    b.Property<int>("review_count")
                        .HasColumnType("integer");

                    b.Property<int>("shop_id")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<int?>("tp_category_id")
                        .HasColumnType("integer");

                    b.Property<int>("transaction_reject")
                        .HasColumnType("integer");

                    b.Property<int>("transaction_success")
                        .HasColumnType("integer");

                    b.Property<string>("weight_unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("tp_product_id");

                    b.HasIndex("tp_category_id");

                    b.ToTable("TpProducts");
                });

            modelBuilder.Entity("Stokpas.Models.VariantModel", b =>
                {
                    b.Property<int>("variant_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Productsproduct_id")
                        .HasColumnType("integer");

                    b.Property<int>("discount_id")
                        .HasColumnType("integer");

                    b.Property<string>("internal_tier_index")
                        .HasColumnType("text");

                    b.Property<float>("original_price")
                        .HasColumnType("real");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<int>("stock")
                        .HasColumnType("integer");

                    b.Property<double[]>("tier_index")
                        .HasColumnType("double precision[]");

                    b.Property<string>("variant_sku")
                        .HasColumnType("text");

                    b.HasKey("variant_id");

                    b.HasIndex("Productsproduct_id");

                    b.ToTable("VariantModels");
                });

            modelBuilder.Entity("Stokpas.Models.VariantOptions", b =>
                {
                    b.Property<int>("variant_option_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("TierVariantstier_variant_id")
                        .HasColumnType("integer");

                    b.Property<string>("hex")
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .HasColumnType("text");

                    b.Property<string>("variant_option_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("variant_option_id");

                    b.HasIndex("TierVariantstier_variant_id");

                    b.ToTable("VariantOptions");
                });

            modelBuilder.Entity("Stokpas.Models.Warehouses", b =>
                {
                    b.Property<int>("warehouse_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("TpProductstp_product_id")
                        .HasColumnType("integer");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("stock")
                        .HasColumnType("integer");

                    b.HasKey("warehouse_id");

                    b.HasIndex("TpProductstp_product_id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Stokpas.Models.Wholesales", b =>
                {
                    b.Property<int>("wholesale_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Productsproduct_id")
                        .HasColumnType("integer");

                    b.Property<int>("max")
                        .HasColumnType("integer");

                    b.Property<int>("min")
                        .HasColumnType("integer");

                    b.Property<float>("unit_price")
                        .HasColumnType("real");

                    b.HasKey("wholesale_id");

                    b.HasIndex("Productsproduct_id");

                    b.ToTable("Wholesales");
                });

            modelBuilder.Entity("Stokpas.Models.Attributes", b =>
                {
                    b.HasOne("Stokpas.Models.ShProducts", null)
                        .WithMany("attributes")
                        .HasForeignKey("ShProductssh_product_id");
                });

            modelBuilder.Entity("Stokpas.Models.Images", b =>
                {
                    b.HasOne("Stokpas.Models.ShProducts", null)
                        .WithMany("images")
                        .HasForeignKey("ShProductssh_product_id");

                    b.HasOne("Stokpas.Models.TpProducts", null)
                        .WithMany("images")
                        .HasForeignKey("TpProductstp_product_id");

                    b.HasOne("Stokpas.Models.Products", "products")
                        .WithMany("images")
                        .HasForeignKey("productsproduct_id")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("Stokpas.Models.Logistics", b =>
                {
                    b.HasOne("Stokpas.Models.ShProducts", null)
                        .WithMany("logistics")
                        .HasForeignKey("ShProductssh_product_id");
                });

            modelBuilder.Entity("Stokpas.Models.Products", b =>
                {
                    b.HasOne("Stokpas.Models.ShProducts", "sh_product")
                        .WithMany()
                        .HasForeignKey("sh_product_id");

                    b.HasOne("Stokpas.Models.TpProducts", "tp_product")
                        .WithMany()
                        .HasForeignKey("tp_product_id");
                });

            modelBuilder.Entity("Stokpas.Models.ShProducts", b =>
                {
                    b.HasOne("Stokpas.Models.ShCategorys", "sh_category")
                        .WithMany()
                        .HasForeignKey("sh_category_id");
                });

            modelBuilder.Entity("Stokpas.Models.TierVariants", b =>
                {
                    b.HasOne("Stokpas.Models.Products", null)
                        .WithMany("tier_variant")
                        .HasForeignKey("Productsproduct_id");
                });

            modelBuilder.Entity("Stokpas.Models.TpProducts", b =>
                {
                    b.HasOne("Stokpas.Models.TpCategorys", "tp_category")
                        .WithMany()
                        .HasForeignKey("tp_category_id");
                });

            modelBuilder.Entity("Stokpas.Models.VariantModel", b =>
                {
                    b.HasOne("Stokpas.Models.Products", null)
                        .WithMany("variant")
                        .HasForeignKey("Productsproduct_id");
                });

            modelBuilder.Entity("Stokpas.Models.VariantOptions", b =>
                {
                    b.HasOne("Stokpas.Models.TierVariants", null)
                        .WithMany("options")
                        .HasForeignKey("TierVariantstier_variant_id");
                });

            modelBuilder.Entity("Stokpas.Models.Warehouses", b =>
                {
                    b.HasOne("Stokpas.Models.TpProducts", null)
                        .WithMany("warehouses")
                        .HasForeignKey("TpProductstp_product_id");
                });

            modelBuilder.Entity("Stokpas.Models.Wholesales", b =>
                {
                    b.HasOne("Stokpas.Models.Products", null)
                        .WithMany("wholesales")
                        .HasForeignKey("Productsproduct_id");
                });
#pragma warning restore 612, 618
        }
    }
}