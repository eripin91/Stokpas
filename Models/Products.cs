using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        [Required]
        public string condition { get; set; }
        public bool has_variation { get; set; } = false;

        [Display(Name = "Harga")]
        [Required]
        public float price { get; set; }

        [Display(Name = "Stok")]
        [Required]
        public int stock { get; set; }

        [Display(Name = "Berat")]
        [Required]
        public int weight { get; set; }

        [Display(Name = "Rating")]
        public int rating_star { get; set; }

        [Display(Name = "Terjual")]
        public int sales { get; set; }

        [Display(Name = "Dilihat")]
        public int view { get; set; }
        public int days_to_ship { get; set; }
        
        [Display(Name = "Tanggal posting")]
        public DateTime created_on { get; set; }
        public string created_by { get; set; }
        public DateTime modified_on { get; set; }
        public string modified_by { get; set; }

        public ICollection<Wholesales> wholesales { get; set; }

        [Display(Name = "Gambar")]
        [Required]
        public ICollection<Images> images { get; set; }
        public ICollection<TierVariants> tier_variant { get; set; }
        public ICollection<VariantModel> variant { get; set; }
        public virtual TpProducts tp_product { get; set; }
        public virtual ShProducts sh_product { get; set; }
    }
}
