using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class WholesaleModel
    {
        public int wholesale_id { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public float unit_price { get; set; }

    }
}
