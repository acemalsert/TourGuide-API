using MediatR;
using TourGuide.Application.Features.Auth.Queries.GetAllUsers;

namespace TourGuide.Application.Features.Auth.Queries.GetGuideById
{
    public class GetGuideByIdQueryRequest : IRequest<GetGuideByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
