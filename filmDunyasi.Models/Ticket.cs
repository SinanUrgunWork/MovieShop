using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int ScreeningID { get; set; }

        [ForeignKey("ScreeningID")]
        public virtual Screening Screening { get; set; }
        public double Price { get; set; }

        public Nullable<int> SeatNo { get; set; }

        public DateTime BuyTime { get; set; }

        // bilet alan kişi eklenecek
    }
}
