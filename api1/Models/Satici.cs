using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Satici
    {
        public Satici()
        {
            Satishes = new HashSet<Satish>();
        }

        public int Id { get; set; }
        public string SaticiAd { get; set; }
        public string SaticiSoyad { get; set; }
        public DateTime? SaticiTevellud { get; set; }
        public string SaticiFin { get; set; }
        public string SaticiUnvan { get; set; }
        public double? SaticiMaas { get; set; }
        public int? FiliAlId { get; set; }

        public virtual Filial FiliAl { get; set; }
        public virtual ICollection<Satish> Satishes { get; set; }
    }
}
