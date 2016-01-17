using System;
using System.Collections.Generic;

namespace cleancode.ui.Models
{
    public partial class Stop
    {
        public long Id { get; set; }
        public string Arrival { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public long Order { get; set; }
        public long? TripId { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
