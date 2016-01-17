using System;
using System.Collections.Generic;

namespace cleancode.ui.Models
{
    public partial class City
    {
        public long ID { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
    }
}
