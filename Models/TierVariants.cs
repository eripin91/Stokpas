using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class TierVariants
    {
        [Key]
        public int tier_variant_id { get; set; }

        [Required]
        public string tier_variant_name { get; set; }
        public int position { get; set; }
        public ICollection<VariantOptions> options { get; set; }
    }
}
