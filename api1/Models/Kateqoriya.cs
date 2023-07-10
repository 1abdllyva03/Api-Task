using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Kateqoriya
    {
        public Kateqoriya()
        {
            Mehsuls = new HashSet<Mehsul>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Mehsul> Mehsuls { get; set; }
    }
}
