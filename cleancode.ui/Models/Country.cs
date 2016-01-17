using System;
using System.Collections.Generic;

namespace cleancode.ui.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            CountryLanguage = new HashSet<CountryLanguage>();
        }

        public string Code { get; set; }
        public long? Capital { get; set; }
        public string Code2 { get; set; }
        public string Continent { get; set; }
        public double? GNP { get; set; }
        public double? GNPOld { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public long? IndepYear { get; set; }
        public double? LifeExpectancy { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public string Region { get; set; }
        public double SurfaceArea { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<CountryLanguage> CountryLanguage { get; set; }
    }
}
