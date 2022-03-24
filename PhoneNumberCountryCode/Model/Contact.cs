using System.Collections.Generic;

namespace PhoneNumberCountryCode.Model
{
    public class Contact
    {
        public string number { get; set; }
        public List<Country> Country { get; set; }
        //public List<CountryDetail> CountryDetails { get; set; }
    }
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetail> CountryDetails { get; set; }
    }
    public class CountryDetail
    {
        //public List<Country> Country { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
