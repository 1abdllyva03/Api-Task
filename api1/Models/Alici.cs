using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Alici
    {
        public Alici()
        {
            Satishes = new HashSet<Satish>();
        }

        public int Id { get; set; }
        public string AliciAd { get; set; }
        public string AliciSoyad { get; set; }
        public string AliciFin { get; set; }
        public string AliciUnvan { get; set; }
        public string AliciTelefon { get; set; }

        public virtual ICollection<Satish> Satishes { get; set; }
    }
}
