using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Filial
    {
        public Filial()
        {
            Saticis = new HashSet<Satici>();
        }

        public int Id { get; set; }
        public string FilialAd { get; set; }

        public virtual ICollection<Satici> Saticis { get; set; }
    }
}
