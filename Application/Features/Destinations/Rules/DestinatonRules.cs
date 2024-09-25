using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourGuide.Application.Bases;
using TourGuide.Application.Features.Destinations.Exceptions;

namespace TourGuide.Application.Features.Destinations.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Destination> destinations, string requestName)
        {
            if (destinations.Any(x => x.Name == requestName)) throw new DestinationTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
