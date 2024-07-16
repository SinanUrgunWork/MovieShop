using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Director
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public GenderType Gender { get; set; }

        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }

        public virtual ICollection<Film> Film { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
           

        }

    }

    public enum GenderType
    {
        Erkek=1,
        Kadın=2
    }
}
