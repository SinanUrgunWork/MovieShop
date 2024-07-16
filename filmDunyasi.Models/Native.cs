using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace filmDunyasi.Models
{
    public class Native
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name="Language Name")]
        public string  Name { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }


    }
}
