using System;
using System.Collections.Generic;

namespace PRN211_Project.Models
{
    public partial class Synonym
    {
        public long FirstId { get; set; }
        public long SecondId { get; set; }
        public string? Username { get; set; }

        public virtual Word First { get; set; } = null!;
        public virtual Word Second { get; set; } = null!;
    }
}
