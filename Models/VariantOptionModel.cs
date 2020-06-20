using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class VariantOptionModel
    {
        [Key]
        public int variant_option_id { get; set; }

        [Required]
        public string variant_option_name { get; set; }
        public string variant_option_url { get; set; }
        public string variant_option_hex { get; set; }
        public string request_id { get; set; }
    }
}
