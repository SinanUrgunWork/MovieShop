using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Comment
    {
        public int ID { get; set; }

        public int FilmID { get; set; }

        [ForeignKey("FilmID")]
        public virtual Film Film { get; set; }

        public string Content { get; set; }

        public DateTime CommentTime { get; set; }

        public double Rating { get; set; }

        // yorum yapan kişi eklenecek


    }
}
