using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Isci
    {
        public Isci()
        {
            Avans = new HashSet<Avan>();
            Loggs = new HashSet<Logg>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double? Maas { get; set; }
        public double? Vergi { get; set; }

        public virtual ICollection<Avan> Avans { get; set; }
        public virtual ICollection<Logg> Loggs { get; set; }
    }
}
