using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class ShCategoryModel
    {
        public int sh_category_id { get; set; }
        public int parent_id { get; set; } = 0;

        [Required]
        public string category_name { get; set; }
        public bool has_children { get; set; } = false;
        public string request_id { get; set; }
    }
}
