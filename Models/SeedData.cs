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
                if (context.Product.Any())
                {
                    //var all = context.Product.Include(s => s.images)
                    //.Include(s => s.logistics)
                    //.Include(s => s.wholesales)
                    //.Include(s => s.tp_category)
                    //.Include(s => s.sh_category);
                    //context.Product.RemoveRange(all);
                    //context.Logistics.RemoveRange(context.Logistics);
                    //context.Wholesales.RemoveRange(context.Wholesales);
                    //context.TpCategorys.RemoveRange(context.TpCategorys);
                    //context.ShCategorys.RemoveRange(context.ShCategorys);
                    //context.SaveChanges();

                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Products
                    {
                        shop_id = 2312312,
                        product_url = "abc.com",
                        status = 1,
                        product_sku = 1231,
                        product_name = "kemoceng",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        product_short_description = "<p>bbb aa</p>",
                        min_order = 1,
                        etalase = "rumah",
                        currency = "IDR",
                        condition = "NEW",
                        price = 1231,
                        original_price = 1231,
                        stock = 33,
                        weight = 99,
                        weight_unit = "gram",
                        timestamp = 512312312311,
                        rating_star = 4,
                        comment_count = 12,
                        review_count = 3,
                        transaction_success = 2,
                        transaction_reject = 1,
                        sales = 2,
                        view = 200,
                        like = 1,
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
                        tp_category = new TpCategorys
                        {
                            category_name = "baju",
                            parent_id = 0
                        },
                        sh_category = new ShCategorys
                        {
                            category_name = "pakaian",
                            parent_id = 0
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    },
                    new Products
                    {
                        shop_id = 2312312,
                        product_url = "bbc.com",
                        status = 1,
                        product_sku = 2231,
                        product_name = "rotan",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        product_short_description = "<p>bbb aa</p>",
                        min_order = 1,
                        etalase = "rumah",
                        currency = "IDR",
                        condition = "NEW",
                        price = 30000,
                        original_price = 1231,
                        stock = 10,
                        weight = 99,
                        weight_unit = "gram",
                        timestamp = 512312312311,
                        rating_star = 4,
                        comment_count = 12,
                        review_count = 3,
                        transaction_success = 2,
                        transaction_reject = 1,
                        sales = 2,
                        view = 200,
                        like = 1,
                        logistics = new List<Logistics>
                        {
                            new Logistics
                            {
                                logistic_name="jnt"
                            },
                            new Logistics
                            {
                                logistic_name="jne"
                            }
                        },
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/nama-bayi-laki-laki-islami.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/Macam-Macam-Zakat.jpg"
                            }
                        },
                        tp_category = new TpCategorys
                        {
                            category_name = "baju",
                            parent_id = 0
                        },
                        sh_category = new ShCategorys
                        {
                            category_name = "pakaian",
                            parent_id = 0
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    },
                    new Products
                    {
                        shop_id = 2312312,
                        product_url = "ccc.com",
                        status = 1,
                        product_sku = 1231,
                        product_name = "botol minum",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        product_short_description = "<p>bbb aa</p>",
                        min_order = 1,
                        etalase = "rumah",
                        currency = "IDR",
                        condition = "NEW",
                        price = 65000,
                        original_price = 1231,
                        stock = 3,
                        weight = 99,
                        weight_unit = "gram",
                        timestamp = 512312312311,
                        rating_star = 4,
                        comment_count = 12,
                        review_count = 3,
                        transaction_success = 2,
                        transaction_reject = 1,
                        sales = 2,
                        view = 200,
                        like = 1,
                        logistics = new List<Logistics>
                        {
                            new Logistics
                            {
                                logistic_name="sicepat"
                            },
                            new Logistics
                            {
                                logistic_name="jnt"
                            }
                        },
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2020/05/6-Macam-Ifthar-Di-Bulan-Ramadhan-820x640.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/rukun-iman-dan-rukun-islam.jpg"
                            }
                        },
                        tp_category = new TpCategorys
                        {
                            category_name = "baju",
                            parent_id = 0
                        },
                        sh_category = new ShCategorys
                        {
                            category_name = "pakaian",
                            parent_id = 0
                        },
                        created_on = DateTime.Now,
                        created_by = "011231asfsdfasdf",
                    },
                    new Products
                    {
                        shop_id = 2312312,
                        product_url = "dbc.com",
                        status = 1,
                        product_sku = 1231,
                        product_name = "speaker aktif",
                        product_description = "<p>Kode Listing pinrumah.com :&nbsp;<strong>36101</strong><br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />GRATIS Konsultasi KPR (BCA, PANIN, CIMB, BNI, Danamon, Permata, dll)<br /><br />SPEK :<br /><br />- LUAS TANAH :26 M2<br />- Luas Bangunan : 26 M2<br />KT 1<br />KM 1<br /><br />HARGA : 540 JT<br /><br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br />(HUB: EDWARD 081280069222)<br /><br />Segera hubungi kami untuk membantu dan mendapatkan informasi mengenai properti di area ini (Listing HOT, harga pasaran dan lokasi terbaik)<br /><br />SHR,SHR,RW</p>",
                        product_short_description = "<p>bbb aa</p>",
                        min_order = 1,
                        etalase = "rumah",
                        currency = "IDR",
                        condition = "NEW",
                        price = 65000,
                        original_price = 1231,
                        stock = 133,
                        weight = 99,
                        weight_unit = "gram",
                        timestamp = 512312312311,
                        rating_star = 4,
                        comment_count = 12,
                        review_count = 3,
                        transaction_success = 2,
                        transaction_reject = 1,
                        sales = 2,
                        view = 200,
                        like = 1,
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
                        images = new List<Images> {
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2019/03/Kisah-Nabi-Ilyas-1.jpg"
                            },
                            new Images
                            {
                                image_file_path="https://pondokislam.com/wp-content/uploads/2018/10/tanda-tanda-kiamat-1181x640.jpg"
                            }
                        },
                        tp_category = new TpCategorys
                        {
                            category_name = "baju",
                            parent_id = 0
                        },
                        sh_category = new ShCategorys
                        {
                            category_name = "pakaian",
                            parent_id = 0
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
