using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Destinations.Queries.GetDestination
{
    public class GetDestinationByIdQueryRequest : IRequest<GetDestinationByIdQueryResponse>
    {
        public int Id { get; set; } 
    }

}
