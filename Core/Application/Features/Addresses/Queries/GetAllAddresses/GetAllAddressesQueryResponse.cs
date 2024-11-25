using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Addresses.Queries.GetAllAddresses
{
    public class GetAllAddressesQueryResponse
    {
        public int Id { get; set; }
        public string StreetNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public int PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        // Foreign Key
        public string CountryNametag { get; set; }
    }
}
