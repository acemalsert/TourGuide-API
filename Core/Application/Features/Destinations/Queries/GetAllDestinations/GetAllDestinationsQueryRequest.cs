using MediatR;
using TourGuide.Application.Interfaces.RedisCache;

namespace TourGuide.Application.Features.Destinations.Queries.GetAllDestinations
{
    // TODO : Closed for fast development
    public class GetAllDestinationsQueryRequest : IRequest<IList<GetAllDestinationsQueryResponse>>/*, ICacheableQuery*/
    {
        //string ICacheableQuery.CacheKey => "GetAllDestinations";

        //public double CacheTime => 60;
    }
}
