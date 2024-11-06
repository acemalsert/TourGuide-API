using Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Addresses.Queries.GetAllAddresses
{
    internal class GetAllAddressesQueryHandler : IRequestHandler<GetAllAddressesQueryRequest, IList<GetAllAddressesQueryResponse>>
    {

        private readonly IUnitOfWork unitOfWork;

        public GetAllAddressesQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllAddressesQueryResponse>> Handle(GetAllAddressesQueryRequest request, CancellationToken cancellationToken)
        {
            var addresses = await unitOfWork.GetReadRepository<Address>().Find(address => address.IsDeleted == false).ToListAsync();

            List<GetAllAddressesQueryResponse> response = new();

            foreach (var address in addresses)
                response.Add(new GetAllAddressesQueryResponse
                {
                    Id = address.Id,
                    AddressLine1 = address.AddressLine1,
                    AddressLine2 = address.AddressLine2,
                    CityName = address.CityName,
                    RegionName = address.RegionName,
                    StreetNo = address.StreetNo,
                    Latitude = address.Latitude,
                    Longitude = address.Longitude,
                    PostalCode = address.PostalCode,
                });

            return response;
        }
    }

}
