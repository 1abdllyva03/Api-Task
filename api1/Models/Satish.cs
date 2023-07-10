using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Satish
    {
        public int Id { get; set; }
        public int? AliciId { get; set; }
        public int? SaticiId { get; set; }
        public int? MehsulId { get; set; }
        public bool? Zemanet { get; set; }
        public DateTime? SatilanTarix { get; set; }
        public double? Endirim { get; set; }
        public int? SatishSay { get; set; }

        public virtual Alici Alici { get; set; }
        public virtual Mehsul Mehsul { get; set; }
        public virtual Satici Satici { get; set; }
    }
}
