using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourGuide.Application.Features.Destinations.Commands.CreateDestination;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Addresses.Commands.CreateAddress
{
    internal class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateAddressCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            Address address = new Address()
            {
                AddressLine1 = request.AddressLine1,
                AddressLine2 = request.AddressLine2,
                CityName = request.CityName,
                CountryId = request.CountryId,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                PostalCode  = request.PostalCode,
                StreetNo = request.StreetNo,
                RegionName = request.RegionName,
            };

            await unitOfWork.GetWriteRepository<Address>().AddAsync(address);

            if (await unitOfWork.SaveAsync() > 0)
            {
                await unitOfWork.SaveAsync();
            }

            return Unit.Value;
        }
    }
}
