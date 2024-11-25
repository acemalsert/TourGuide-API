using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;


namespace TourGuide.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public PaymentsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class ProductRequest
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public int Amount { get; set; }
            public string Currency { get; set; }
            public int NoOfProducts {  get; set; }
        }

        [HttpPost]
        public IActionResult CreateCheckoutSession([FromBody] ProductRequest productRequest)
        {
            
            StripeConfiguration.ApiKey = _configuration["Stripe:SecretKey"];

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = productRequest.Amount * 100,
                        Currency = productRequest.Currency,
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = productRequest.ProductName,
                        },
                    },
                    Quantity = productRequest.Quantity,
                },
            },
                Mode = "payment",
                SuccessUrl = _configuration["Stripe:SuccessUrl"],
                CancelUrl = _configuration["Stripe:CancelUrl"],
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return Ok(new { sessionId = session.Id });
        }


    }
}