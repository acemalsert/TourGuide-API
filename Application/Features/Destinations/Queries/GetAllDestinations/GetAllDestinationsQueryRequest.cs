using MediatR;

namespace TourGuide.Application.Features.Destinations.Queries.GetAllDestinations
{
    public class GetAllDestinationsQueryRequest : IRequest<IList<GetAllDestinationsQueryResponse>>
    {
    }
}
