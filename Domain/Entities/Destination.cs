using Domain.Common;
using TourGuide.Domain.Entities;

namespace Domain.Entities
{
    public class Destination : EntityBase
    {
        public Destination() { }

        public Destination(string name, string description,
                          DateTime openingTime, DateTime closingTime, decimal ticketPrice,
                          string imageData, int categoryId, int? addressId = null)
        {
            Name = name;
            Description = description;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            TicketPrice = ticketPrice;
            ImageData = imageData;
            CategoryId = categoryId;
            AddressId = addressId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public decimal TicketPrice { get; set; }
        public string ImageData { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public int? AddressId { get; set; }

        // Navigation Properties
        public Category Category { get; set; }
        public Address Address { get; set; }
    }
}
