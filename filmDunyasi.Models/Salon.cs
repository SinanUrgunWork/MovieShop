using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Salon
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int CinemaID { get; set; }

        [ForeignKey("CinemaID")]
        public virtual Cinema Cinema { get; set; }
    }
}
