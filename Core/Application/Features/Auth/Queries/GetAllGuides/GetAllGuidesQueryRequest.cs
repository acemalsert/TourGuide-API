using MediatR;
using TourGuide.Application.Features.Auth.Queries.GetAllUsers;

namespace TourGuide.Application.Features.Auth.Queries.GetAllGuides
{
    public class GetAllGuidesQueryRequest : IRequest<IList<GetAllGuidesQueryResponse>>
    {
    }
}
