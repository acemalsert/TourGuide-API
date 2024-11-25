using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Commands.CreateDestination
{
    public class CreateDestinationCommandRequest : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public decimal TicketPrice { get; set; }
        public string ImageData { get; set; }
        public int CategoryId { get; set; }
    }
}
