using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Insan
    {
        public Insan()
        {
            Nomres = new HashSet<Nomre>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Nomre> Nomres { get; set; }
    }
}
