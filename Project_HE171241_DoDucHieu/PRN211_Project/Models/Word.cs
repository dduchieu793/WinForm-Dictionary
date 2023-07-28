using System;
using System.Collections.Generic;

namespace PRN211_Project.Models
{
    public partial class Word
    {
        public Word()
        {
            Histories = new HashSet<History>();
            SynonymFirsts = new HashSet<Synonym>();
            SynonymSeconds = new HashSet<Synonym>();
            Usernames = new HashSet<User>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Meaning { get; set; }
        public byte? TypeId { get; set; }
        public string? Username { get; set; }

        public virtual Type? Type { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Synonym> SynonymFirsts { get; set; }
        public virtual ICollection<Synonym> SynonymSeconds { get; set; }

        public virtual ICollection<User> Usernames { get; set; }
    }
}
