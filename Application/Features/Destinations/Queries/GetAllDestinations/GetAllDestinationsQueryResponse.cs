using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Queries.GetAllDestinations
{
    public class GetAllDestinationsQueryResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageData { get; set; }

    }
}
