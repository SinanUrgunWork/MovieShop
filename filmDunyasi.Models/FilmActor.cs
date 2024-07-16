using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class FilmActor
    {
        [Key]
        public int ID { get; set; }

        public int FilmID { get; set; }

        [ForeignKey("FilmID")]
        public virtual Film Film { get; set; }

        public int ActorID { get; set; }

        [ForeignKey("ActorID")]
        public virtual Actor Actor { get; set; }

        public int DisplayOrder { get; set; }

    }
}
