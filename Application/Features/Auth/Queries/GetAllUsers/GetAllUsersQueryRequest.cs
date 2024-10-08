using MediatR;

namespace TourGuide.Application.Features.Auth.Queries.GetAllUsers
{
    public class GetAllUsersQueryRequest : IRequest<IList<GetAllUsersQueryResponse>>
    {
    }
}
