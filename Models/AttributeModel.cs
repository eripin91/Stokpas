using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Models
{
    public class AttributeModel
    {
        public int attribute_id { get; set; }

        [Required]
        public string attribute_name { get; set; }        
        public bool is_mandatory { get; set; } = false;
        public string attribute_type { get; set; }
        public string attribute_value { get; set; }
        public string internal_option { get; set; }
        public string[] options
        {
            get
            {
                return internal_option.Split(';');
            }
            set
            {
                internal_option = String.Join(";", value);
            }
        }
        public string request_id { get; set; }
    }
}
