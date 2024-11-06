﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Queries.GetDestination
{
    public class GetDestinationByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageData { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
