using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class TpProducts
    {
        [Key]
        public int tp_product_id { get; set; }

        [Required]
        public int shop_id { get; set; }

        [Display(Name = "URL")]
        public string product_url { get; set; }

        [Display(Name = "Status")]
        [Required]
        public int status { get; set; } = 1;

        [Display(Name = "Deskripsi singkat")]
        public string product_short_description { get; set; }

        [Display(Name = "Min. order")]
        [Required]
        public int min_order { get; set; }

        [Display(Name = "Etalase")]
        [Required]
        public string etalase { get; set; }

        [Display(Name = "Harus Asuransi?")]
        public bool is_must_insurance { get; set; } = false;

        [Display(Name = "Free return?")]
        public bool is_free_return { get; set; } = false;

        [Display(Name = "Bisa COD?")]
        public bool is_eligible_cod { get; set; } = false;

        [Display(Name = "Satuan berat")]
        [Required]
        public string weight_unit { get; set; }

        [Display(Name = "Jumlah ulasan")]
        public int review_count { get; set; }

        [Display(Name = "Transaksi sukses")]
        public int transaction_success { get; set; }

        [Display(Name = "Transaksi ditolak")]
        public int transaction_reject { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime created_on { get; set; }
        public string created_by { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime modified_on { get; set; }
        public string modified_by { get; set; }

        [Required]
        public ICollection<Images> images { get; set; }
        public ICollection<Warehouses> warehouses { get; set; }        
        public virtual TpCategorys tp_category { get; set; }
    }
}
