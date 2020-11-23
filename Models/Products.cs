using Stokpas.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        [Display(Name = "SKU")]
        public int product_sku { get; set; }

        [Display(Name = "Nama produk")]
        [Required]
        public string product_name { get; set; }

        [Display(Name = "Deskripsi")]
        [Required]
        public string product_description { get; set; }
        public string currency { get; set; }

        [Display(Name = "Kondisi")]
        [Required]
        public string condition { get; set; }
        public bool has_variation { get; set; } = false;

        [Display(Name = "Harga")]
        [Required]
        public float price { get; set; }

        [Display(Name = "Stok")]
        [Required]
        public int stock { get; set; }

        [Display(Name = "Berat(gram)")]
        [Required]
        public int weight { get; set; }

        [Display(Name = "Rating")]
        public int rating_star { get; set; }

        [Display(Name = "Terjual")]
        public int sales { get; set; }

        [Display(Name = "Dilihat")]
        public int view { get; set; }

        [Display(Name = "Lama pengiriman")]
        public int days_to_ship { get; set; }
        public DateTime created_on { get; set; }

        [NotMapped]
        [Display(Name = "Tanggal posting")]
        public string Created_on
        {
            get
            {
                if (created_on == DateTime.MinValue)
                {
                    return string.Empty;
                }
                return ((DateTime)created_on).ToString(Constant.date_format);
            }
            set
            {
                created_on = DateTime.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        [Display(Name = "Akun pembuat")]
        public string created_by { get; set; }
                
        public DateTime modified_on { get; set; }

        [NotMapped]
        [Display(Name = "Tanggal edit")]
        public string Modified_on
        {
            get
            {
                if (modified_on == DateTime.MinValue)
                {
                    return string.Empty;
                }
                return ((DateTime)modified_on).ToString(Constant.date_format);
            }
            set
            {
                modified_on = DateTime.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        [Display(Name = "Akun pengedit")]
        public string modified_by { get; set; }

        [Display(Name = "Grosir")]
        public ICollection<Wholesales> wholesales { get; set; }

        [Display(Name = "Gambar")]        
        public ICollection<Images> images { get; set; }
        public ICollection<TierVariants> tier_variant { get; set; }
        public ICollection<VariantModel> variant { get; set; }
        public virtual TpProducts tp_product { get; set; }
        public virtual ShProducts sh_product { get; set; }
    }
}
