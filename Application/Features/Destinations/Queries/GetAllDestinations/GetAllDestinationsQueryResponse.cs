using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Queries.GetAllDestinations
{
    public class GetAllDestinationsQueryResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
