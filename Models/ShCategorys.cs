using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class ShCategorys
    {
        [Key]
        public int sh_category_id { get; set; }
        public int parent_id { get; set; } = 0;

        [Display(Name = "Nama kategori")]
        [Required]
        public string category_name { get; set; }
        public bool has_children { get; set; } = false;
    }
}
