using Domain.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Domain.Entities
{
    public class Ticket : EntityBase
    {
        public Ticket() { }

        public Ticket(int tourId, Guid userId, DateTime purchaseDate, decimal price, int? paymentId = null)
        {
            TourId = tourId;
            UserId = userId;
            PurchaseDate = purchaseDate;
            Price = price;
            PaymentId = paymentId;
        }

        // Foreign Keys
        public int TourId { get; set; }
        public Guid UserId { get; set; }
        public int? PaymentId { get; set; }

        // Properties
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }

        // Navigation Properties
        public Destination Tour { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
    }

}
