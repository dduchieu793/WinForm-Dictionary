using System;
using System.Collections.Generic;

namespace PRN211_Project.Models
{
    public partial class History
    {
        public string Username { get; set; } = null!;
        public long Id { get; set; }
        public DateTime? Addtime { get; set; }

        public virtual Word IdNavigation { get; set; } = null!;
        public virtual User UsernameNavigation { get; set; } = null!;
    }
}
