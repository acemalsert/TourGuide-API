using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourGuide.Application.Bases;

namespace TourGuide.Application.Features.Destinations.Exceptions
{
    public class DestinationTitleMustNotBeSameException : BaseExceptions
    {
        public DestinationTitleMustNotBeSameException() : base("Destination başlığı zaten var!") { }
    }
}
