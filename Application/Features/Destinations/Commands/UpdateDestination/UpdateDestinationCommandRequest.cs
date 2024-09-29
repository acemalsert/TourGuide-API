using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Commands.UpdateDestination
{
    public class UpdateDestinationCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Location { get; set; }
        //public double Latitude { get; set; }
        //public double Longitude { get; set; }
        //public TimeSpan OpeningTime { get; set; }
        //public TimeSpan ClosingTime { get; set; }
        //public decimal TicketPrice { get; set; }
        //public string ImageUrl { get; set; }
        //public int CategoryId { get; set; }
    }
}
