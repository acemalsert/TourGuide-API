using Domain.Common;
using Domain.Entities;

namespace TourGuide.Domain.Entities
{
    public class DestinationAddress : EntityBase
    {
        public int DestinationId { get; set; }
        public int? AddressId { get; set; }

        // Navigation Properties
        public Destination Destination { get; set; }
        public Address Address { get; set; }
    }
}
