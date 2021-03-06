﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class ShProducts
    {
        [Key]
        public int sh_product_id { get; set; }
        public int shop_id { get; set; }

        [Display(Name = "URL")]
        public string product_url { get; set; }

        [Display(Name = "Status")]
        public int status { get; set; } = 1;

        [Display(Name = "Harga original")]
        public float original_price { get; set; }

        [Display(Name = "Jumlah komentar")]
        public int comment_count { get; set; }

        [Display(Name = "Panjang paket")]
        public int package_length { get; set; }

        [Display(Name = "Lebar paket")]
        public int package_width { get; set; }

        [Display(Name = "Tinggi paket")]
        public int package_height { get; set; }

        [Display(Name = "Preorder?")]
        public bool is_pre_order { get; set; } = false;

        [Display(Name = "Like")]
        public int like { get; set; }
        public int discount_id { get; set; }
        public string warning { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime created_on { get; set; }
        public string created_by { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime modified_on { get; set; }
        public string modified_by { get; set; }

        public ICollection<Attributes> attributes { get; set; }

        [Display(Name = "Logistik")]
        
        public IList<Logistics> logistics { get; set; }
        
        public ICollection<Images> images { get; set; }

        public virtual ShCategorys sh_category { get; set; }
    }
}
