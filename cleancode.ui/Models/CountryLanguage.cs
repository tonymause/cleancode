using System;
using System.Collections.Generic;

namespace cleancode.ui.Models
{
    public partial class CountryLanguage
    {
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string IsOfficial { get; set; }
        public double Percentage { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
    }
}
