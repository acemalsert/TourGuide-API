using TourGuide.Application.Bases;

namespace TourGuide.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseExceptions
    {
        public EmailAddressShouldBeValidException() : base("Böyle bir email adresi bulunmamaktadır.") { }
    }
}
