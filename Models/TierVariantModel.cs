using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class TierVariantModel
    {
        public int tier_variant_id { get; set; }

        [Required]
        public string tier_variant_name { get; set; }
        public int position { get; set; }
        public ICollection<VariantOptionModel> options { get; set; }
        public string request_id { get; set; }
    }
}
