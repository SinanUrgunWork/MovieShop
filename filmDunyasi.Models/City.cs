using System;
using System.Collections.Generic;
using System.Text;

namespace filmDunyasi.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Town> Town { get; set; }
    }
}
