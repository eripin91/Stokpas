using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class LogisticModel
    {
        public int logistic_id { get; set; }

        [Required]
        public string logistic_name { get; set; }
        public int status { get; set; } = 0;
        public float shipping_fee { get; set; }

        public bool is_free { get; set; } = false;
        public string request_id { get; set; }
    }
}
