using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Logg
    {
        public int Id { get; set; }
        public DateTime? Tarix { get; set; }
        public string Sebeb { get; set; }
        public int? IsciId { get; set; }

        public virtual Isci Isci { get; set; }
    }
}
