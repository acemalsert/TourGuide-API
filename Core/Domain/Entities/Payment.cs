using Domain.Common;

namespace TourGuide.Domain.Entities
{
    public class Payment : EntityBase
    {
        public Payment() { }

        public Payment(string transactionId, decimal amount, DateTime paymentDate)
        {
            TransactionId = transactionId;
            Amount = amount;
            PaymentDate = paymentDate;
        }

        // Properties
        public string TransactionId { get; set; } // Stripe Transaction ID
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        // Navigation Property
        public ICollection<Ticket> Tickets { get; set; }
    }

}
