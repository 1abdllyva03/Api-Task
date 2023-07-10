using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class Status
    {
        public Status()
        {
            User2s = new HashSet<User2>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<User2> User2s { get; set; }
    }
}
