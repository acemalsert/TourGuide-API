using MediatR;

namespace TourGuide.Application.Features.Addresses.Queries.GetAllAddresses
{
    public class GetAllAddressesQueryRequest : IRequest<IList<GetAllAddressesQueryResponse>>
    {
    }
}
