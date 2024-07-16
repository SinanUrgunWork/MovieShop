using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Screening
    {
        public int ID { get; set; }
        public int FilmID { get; set; }

        [ForeignKey("FilmID")]
        public virtual Film Film { get; set; }

        public int SalonID { get; set; }

        [ForeignKey("SalonID")]
        public virtual Salon Salon { get; set; }

        public DateTime StartDate { get; set; }

        public bool SubTitle { get; set; }
    }
}
