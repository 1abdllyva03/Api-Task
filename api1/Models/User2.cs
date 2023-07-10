using System;
using System.Collections.Generic;

#nullable disable

namespace api1.Models
{
    public partial class User2
    {
        public int Id { get; set; }
        public string UserAd { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
    }
}
