using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Stokpas.Data;

namespace Stokpas.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StokpasContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StokpasContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {                    

                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Products
                    {                        
                        product_sku = 1231,
                        product_name = "kemoceng",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        currency = "IDR",
                        condition = "NEW",
                        price = 1231,
                        stock = 33,
                        weight = 99,
                        rating_star = 4,
                        sales = 2,
                        view = 200,
                        wholesales = new List<Wholesales>
                        {
                            new Wholesales
                            {
                                min = 3,
                                max = 10,
                                unit_price = 2000
                            },
                            new Wholesales
                            {
                                min = 11,
                                max = 20,
                                unit_price = 1900
                            },
                            new Wholesales
                            {
                                min = 21,
                                unit_price = 1800
                            }
                        },
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Sunnah-Nabi-pada-Idhul-Fitri-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Puasa-Ayyamul-Bidh-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/04/Orang-yang-Diperbolehkan-Tidak-Puasa-dan-Ketentuan-Membayar-Hutang-Puasa-821x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/nama-bayi-perempuan.jpg"
                            }
                        },                      
                        
                        tp_product = new TpProducts
                        {
                            shop_id = 2312312,
                            product_url = "tpde.com/bla",
                            status = 1,
                            product_short_description = "<p>bbb aa</p>",
                            min_order = 1,
                            etalase = "rumah",
                            weight_unit = "gram",
                            review_count = 3,
                            transaction_success = 2,
                            transaction_reject = 1,
                            tp_category = new TpCategorys
                            {
                                category_name = "rumah tangga",
                                parent_id = 0
                            },
                        },
                        sh_product = new ShProducts
                        {
                            shop_id = 6984141,
                            product_url = "shope.com/bla",
                            status = 1,
                            original_price = 1231,
                            comment_count = 12,
                            like=90,
                            logistics = new List<Logistics>
                            {
                                new Logistics
                                {
                                    logistic_name="wahana"
                                },
                                new Logistics
                                {
                                    logistic_name="jne"
                                }
                            },
                            sh_category = new ShCategorys
                            {
                                category_name = "rumah tangga",
                                parent_id = 0
                            }
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    },
                    new Products
                    {
                        product_sku = 3325,
                        product_name = "rotan",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        currency = "IDR",
                        condition = "NEW",
                        price = 20000,
                        stock = 133,
                        weight = 10,
                        rating_star = 4,
                        sales = 2,
                        view = 200,
                        wholesales = new List<Wholesales>
                        {
                            new Wholesales
                            {
                                min = 3,
                                max = 10,
                                unit_price = 2000
                            },
                            new Wholesales
                            {
                                min = 11,
                                max = 20,
                                unit_price = 1900
                            },
                            new Wholesales
                            {
                                min = 21,
                                unit_price = 1800
                            }
                        },
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Sunnah-Nabi-pada-Idhul-Fitri-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Puasa-Ayyamul-Bidh-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/04/Orang-yang-Diperbolehkan-Tidak-Puasa-dan-Ketentuan-Membayar-Hutang-Puasa-821x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/nama-bayi-perempuan.jpg"
                            }
                        },

                        tp_product = new TpProducts
                        {
                            shop_id = 3312312,
                            product_url = "tpde.com/blab",
                            status = 1,
                            product_short_description = "<p>bbb aa</p>",
                            min_order = 1,
                            etalase = "rumah",
                            weight_unit = "gram",
                            review_count = 3,
                            transaction_success = 2,
                            transaction_reject = 1,
                            tp_category = new TpCategorys
                            {
                                category_name = "kerajinan",
                                parent_id = 0
                            },
                        },
                        sh_product = new ShProducts
                        {
                            shop_id = 7984141,
                            product_url = "shope.com/blab",
                            status = 1,
                            original_price = 1231,
                            comment_count = 12,
                            like=8,
                            logistics = new List<Logistics>
                            {
                                new Logistics
                                {
                                    logistic_name="jnt"
                                }
                            },
                            sh_category = new ShCategorys
                            {
                                category_name = "kesenian",
                                parent_id = 0
                            }
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    },
                    new Products
                    {
                        product_sku = 5231,
                        product_name = "sepatu",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        currency = "IDR",
                        condition = "NEW",
                        price = 65800,
                        stock = 33,
                        weight = 99,
                        rating_star = 4,
                        sales = 2,
                        view = 200,
                        wholesales = new List<Wholesales>
                        {
                            new Wholesales
                            {
                                min = 3,
                                max = 10,
                                unit_price = 2000
                            },
                            new Wholesales
                            {
                                min = 11,
                                max = 20,
                                unit_price = 1900
                            },
                            new Wholesales
                            {
                                min = 21,
                                unit_price = 1800
                            }
                        },
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Sunnah-Nabi-pada-Idhul-Fitri-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Puasa-Ayyamul-Bidh-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/04/Orang-yang-Diperbolehkan-Tidak-Puasa-dan-Ketentuan-Membayar-Hutang-Puasa-821x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/nama-bayi-perempuan.jpg"
                            }
                        },

                        tp_product = new TpProducts
                        {
                            shop_id = 4312312,
                            product_url = "tpde.com/blac",
                            status = 1,
                            product_short_description = "<p>bbb aa</p>",
                            min_order = 1,
                            etalase = "rumah",
                            weight_unit = "gram",
                            review_count = 3,
                            transaction_success = 2,
                            transaction_reject = 1,
                            tp_category = new TpCategorys
                            {
                                category_name = "pakaian",
                                parent_id = 0
                            },
                        },
                        sh_product = new ShProducts
                        {
                            shop_id = 9984141,
                            product_url = "shope.com/blac",
                            status = 1,
                            original_price = 1231,
                            comment_count = 12,
                            like=3,
                            logistics = new List<Logistics>
                            {
                                new Logistics
                                {
                                    logistic_name="jne"
                                }
                            },
                            sh_category = new ShCategorys
                            {
                                category_name = "aksesoris",
                                parent_id = 0
                            }
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    },
                    new Products
                    {
                        product_sku = 6898,
                        product_name = "tas",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        currency = "IDR",
                        condition = "NEW",
                        price = 1231,
                        stock = 33,
                        weight = 99,
                        rating_star = 4,
                        sales = 2,
                        view = 200,
                        wholesales = new List<Wholesales>
                        {
                            new Wholesales
                            {
                                min = 3,
                                max = 10,
                                unit_price = 2000
                            },
                            new Wholesales
                            {
                                min = 11,
                                max = 20,
                                unit_price = 1900
                            },
                            new Wholesales
                            {
                                min = 21,
                                unit_price = 1800
                            }
                        },
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Sunnah-Nabi-pada-Idhul-Fitri-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Puasa-Ayyamul-Bidh-1280x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/04/Orang-yang-Diperbolehkan-Tidak-Puasa-dan-Ketentuan-Membayar-Hutang-Puasa-821x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/nama-bayi-perempuan.jpg"
                            }
                        },

                        tp_product = new TpProducts
                        {
                            shop_id = 4312312,
                            product_url = "tpde.com/blad",
                            status = 1,
                            product_short_description = "<p>bbb aa</p>",
                            min_order = 1,
                            etalase = "rumah",
                            weight_unit = "gram",
                            review_count = 3,
                            transaction_success = 2,
                            transaction_reject = 1,
                            tp_category = new TpCategorys
                            {
                                category_name = "rumah tangga",
                                parent_id = 0
                            },
                        },
                        sh_product = new ShProducts
                        {
                            shop_id = 9084141,
                            product_url = "shope.com/blad",
                            status = 1,
                            original_price = 1231,
                            comment_count = 12,
                            like=131,
                            logistics = new List<Logistics>
                            {
                                new Logistics
                                {
                                    logistic_name="sicepat"
                                },
                                new Logistics
                                {
                                    logistic_name="jne"
                                }
                            },
                            sh_category = new ShCategorys
                            {
                                category_name = "rumah tangga",
                                parent_id = 0
                            }
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
