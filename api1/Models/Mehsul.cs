using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Mehsul
    {
        public Mehsul()
        {
            Satishes = new HashSet<Satish>();
        }

        public int Id { get; set; }
        public int? Say { get; set; }
        public double? MayaDeyer { get; set; }
        public double? SatishDeyer { get; set; }
        public int? Modelid { get; set; }
        public int? KateqoriyaId { get; set; }

        public virtual Kateqoriya Kateqoriya { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<Satish> Satishes { get; set; }
    }
}
