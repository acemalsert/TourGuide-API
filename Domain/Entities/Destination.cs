using Domain.Common;
using TourGuide.Domain.Entities;

namespace Domain.Entities
{
    public class Destination : EntityBase
    {
        public Destination() { }

        public Destination(string name, string description, string location, double latitude, double longitude,
                          TimeSpan openingTime, TimeSpan closingTime, decimal ticketPrice,
                          string imageUrl, int categoryId, int? addressId = null)
        {
            Name = name;
            Description = description;
            Location = location;
            Latitude = latitude;
            Longitude = longitude;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            TicketPrice = ticketPrice;
            ImageUrl = imageUrl;
            CategoryId = categoryId;
            AddressId = addressId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        // TODO : bu alanı silmek lazım
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public decimal TicketPrice { get; set; }
        public string ImageUrl { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public int? AddressId { get; set; }

        // Navigation Properties
        public Category Category { get; set; }
        public Address Address { get; set; }
    }
}
