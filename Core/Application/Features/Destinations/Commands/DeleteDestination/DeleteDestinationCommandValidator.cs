using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Commands.DeleteDestination
{
    public class DeleteDestinationCommandValidator : AbstractValidator<DeleteDestinationCommandRequest>
    {
        public DeleteDestinationCommandValidator() 
        {
            RuleFor(x => x.Id)
               .GreaterThan(0);
        }
    }
}
