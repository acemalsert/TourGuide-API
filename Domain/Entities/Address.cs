using Domain.Common;

namespace TourGuide.Domain.Entities
{
    public class Address : EntityBase
    {
        public Address() { }

        public string StreetNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public int PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        // Foreign Key
        public int CountryId { get; set; }

        // Navigation Property
        public Country Country { get; set; }
    }
}
