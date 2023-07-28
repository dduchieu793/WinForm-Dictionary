using System;
using System.Collections.Generic;

namespace PRN211_Project.Models
{
    public partial class Type
    {
        public Type()
        {
            Words = new HashSet<Word>();
        }

        public byte Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Word> Words { get; set; }
    }
}
