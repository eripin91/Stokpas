using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class productModel
    {
        public int product_id { get; set; }
        [Required]
        public int shop_id { get; set; }
        public string product_url { get; set; }
        [Required]
        public int status { get; set; } = 1;
        public int product_sku { get; set; }
        [Required]
        public string product_name { get; set; }
        [Required]
        public string product_description { get; set; }
        public string product_short_description { get; set; }
        [Required]
        public int min_order { get; set; }
        [Required]
        public string etalase { get; set; }
        public bool is_must_insurance { get; set; }
        public bool is_free_return { get; set; }
        public bool is_eligible_cod { get; set; }
        public string currency { get; set; }
        [Required]
        public string condition { get; set; }
        public bool has_variation{ get; set; }
        [Required]
        public float price { get; set; }
        public float original_price { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public int weight { get; set; }
        [Required]
        public string weight_unit { get; set; }
        [Required]
        public Int64 timestamp { get; set; }
        public int rating_star { get; set; }
        public int comment_count { get; set; }
        public int review_count { get; set; }
        public int transaction_success { get; set; }
        public int transaction_reject { get; set; }
        public int sales { get; set; }
        public int view { get; set; }
        public int like { get; set; }
        public int package_length { get; set; }
        public int package_width { get; set; }
        public int package_height { get; set; }
        public bool is_pre_order { get; set; }
        public int days_to_ship { get; set; }
        public int discount_id { get; set; }
        public string warning { get; set; }
        public ICollection<WholesaleModel> wholesales { get; set; }
        [Required]
        public ICollection<LogisticModel> logistics { get; set; }
        [Required]
        public ICollection<ImageModel> images { get; set; }
        //video
        [Required]
        public virtual TpCategoryModel tp_category { get; set; }
        [Required]
        public virtual ShCategoryModel sh_category { get; set; }
        public DateTime created_on { get; set; }
        public string created_by { get; set; }
        public DateTime modified_on { get; set; }
        public string modified_by { get; set; }
        public string request_id { get; set; }
    }
}
