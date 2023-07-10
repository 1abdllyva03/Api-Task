using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Nomre
    {
        public int Id { get; set; }
        public string NomreAd { get; set; }
        public int? InsanId { get; set; }

        public virtual Insan Insan { get; set; }
    }
}
