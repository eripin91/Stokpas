using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class TpCategorys
    {
        [Key]
        public int tp_category_id { get; set; }
        public int parent_id { get; set; } = 0;

        [Display(Name = "Nama kategori")]
        [Required]
        public string category_name { get; set; }
    }
}
