using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace filmDunyasi.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        [Display(Name="Ülke Adı")]
        public string Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }


    }
}
