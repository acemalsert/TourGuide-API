using Domain.Common;

namespace TourGuide.Domain.Entities
{
    public class Country : EntityBase
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
        }

        public Country(string countryName) : this()
        {
            CountryName = countryName;
        }

        public string CountryName { get; set; }

        // Navigation Property
        public ICollection<Address> Addresses { get; set; }
    }
}
