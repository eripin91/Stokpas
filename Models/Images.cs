using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string request_id { get; set; }
    }
}
