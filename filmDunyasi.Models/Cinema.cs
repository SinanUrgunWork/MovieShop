using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Cinema
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public string Address { get; set; }
        public int TownID { get; set; }

        [ForeignKey("TownID")]
        public virtual Town Town { get; set; }

        public virtual ICollection<Salon> Salon { get; set; }


    }
}
