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
        public string product_url { get; set; }

        [Required]
        public int status { get; set; } = 1;
        public string product_short_description { get; set; }

        [Required]
        public int min_order { get; set; }

        [Required]
        public string etalase { get; set; }
        public bool is_must_insurance { get; set; } = false;
        public bool is_free_return { get; set; } = false;
        public bool is_eligible_cod { get; set; } = false;

        [Display(Name = "Satuan berat")]
        [Required]
        public string weight_unit { get; set; }

        [Display(Name = "Jumlah ulasan")]
        public int review_count { get; set; }
        public int transaction_success { get; set; }
        public int transaction_reject { get; set; }

        
        public DateTime created_on { get; set; }
        public string created_by { get; set; }
        public DateTime modified_on { get; set; }
        public string modified_by { get; set; }

        [Required]
        public ICollection<Images> images { get; set; }
        public ICollection<Warehouses> warehouses { get; set; }
        public virtual TpCategorys tp_category { get; set; }
    }
}
