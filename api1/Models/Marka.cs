using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Marka
    {
        public Marka()
        {
            Models = new HashSet<Model>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}
