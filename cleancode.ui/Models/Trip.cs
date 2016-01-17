using System;
using System.Collections.Generic;

namespace cleancode.ui.Models
{
    public partial class Trip
    {
        public Trip()
        {
            Stop = new HashSet<Stop>();
        }

        public long Id { get; set; }
        public string Created { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Stop> Stop { get; set; }
    }
}
