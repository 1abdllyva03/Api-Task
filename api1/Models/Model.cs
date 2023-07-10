using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Model
    {
        public Model()
        {
            Mehsuls = new HashSet<Mehsul>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int? MarkaId { get; set; }

        public virtual Marka Marka { get; set; }
        public virtual ICollection<Mehsul> Mehsuls { get; set; }
    }
}
