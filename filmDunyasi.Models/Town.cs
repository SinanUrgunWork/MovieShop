using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Town
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CityID { get; set; }

        [ForeignKey("CityID")]
        public virtual City City { get; set; }

    public virtual ICollection<Cinema> Cinema { get; set; }
    }
}
