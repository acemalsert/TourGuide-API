using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourGuide.Application.Features.Destinations.Commands.CreateDestination;

namespace TourGuide.Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateAddressCommandValidator : AbstractValidator<CreateDestinationCommandRequest>
    {
        public CreateAddressCommandValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .WithName("İsim");
        }
    }
}
