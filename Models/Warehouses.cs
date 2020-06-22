using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class Warehouses
    {
        [Key]
        public int warehouse_id { get; set; }
        public float price { get; set; }
        public int stock { get; set; }

    }
}
