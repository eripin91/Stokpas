using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class VariantModel
    {
        public int variant_id { get; set; }

        public productModel product { get; set; }
        public float price { get; set; }
        public int stock { get; set; }
        public int status { get; set; }
        public string variant_sku { get; set; }
        public string internal_tier_index { get; set; }
        public double[] tier_index
        {
            get
            {
                return Array.ConvertAll(internal_tier_index.Split(';'), Double.Parse);
            }
            set
            {
                internal_tier_index = String.Join(";", value.Select(p => p.ToString()).ToArray());
            }
        }
        public float original_price { get; set; }
        public int discount_id { get; set; }
        public string request_id { get; set; }
    }
}
