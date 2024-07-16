using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Film
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public int NativeID { get; set; }

        [ForeignKey("NativeID")]
        public virtual Native Native { get; set; }

        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public int Duration { get; set; }

        public double IMDBRating { get; set; }

        public string Description { get; set; }

        public string Banner { get; set; }

        public string Trailer { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public virtual ICollection<FilmActor> FilmActor { get; set; }

        public int DirectorID { get; set; }

        [ForeignKey("DirectorID")]
        public virtual Director Director { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }





    }
}
