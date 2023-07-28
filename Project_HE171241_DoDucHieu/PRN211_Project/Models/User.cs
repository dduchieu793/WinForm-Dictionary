using System;
using System.Collections.Generic;

namespace PRN211_Project.Models
{
    public partial class User
    {
        public User()
        {
            Histories = new HashSet<History>();
            Ids = new HashSet<Word>();
        }

        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public byte? IsAdmin { get; set; }

        public virtual ICollection<History> Histories { get; set; }

        public virtual ICollection<Word> Ids { get; set; }
    }
}
