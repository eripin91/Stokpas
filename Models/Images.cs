using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class Images
    {
        [Key]
        public int image_id { get; set; }

        [Required]
        public string image_file_path { get; set; }
        public string image_file_name { get; set; }
        public string image_description { get; set; }        
        public Products products { get; set; }
        public TpProducts tp_products { get; set; }
        public ShProducts sh_products { get; set; }
    }
}
