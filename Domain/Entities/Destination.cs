using Domain.Common;

namespace Domain.Entities
{
    public class Destination : EntityBase
    {
        public Destination()
        {
        }
        public Destination(string name, string description, string location, double latitude, double longitude, TimeSpan openingTime, TimeSpan closingTime, decimal ticketPrice, string imageUrl, int categoryId)
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
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }

        public decimal TicketPrice { get; set; }

        // Image can be a URL or binary data
        public string ImageUrl { get; set; } // Or byte[] if you store the image in the DB

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; }
    }

}
