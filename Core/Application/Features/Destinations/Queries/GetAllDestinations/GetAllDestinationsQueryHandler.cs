using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace TourGuide.Application.Features.Destinations.Queries.GetAllDestinations
{
    public class GetAllDestinationsQueryHandler : IRequestHandler<GetAllDestinationsQueryRequest, IList<GetAllDestinationsQueryResponse>>
    {

        private readonly IUnitOfWork unitOfWork;

        public GetAllDestinationsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllDestinationsQueryResponse>> Handle(GetAllDestinationsQueryRequest request, CancellationToken cancellationToken)
        {
            var destinations = await unitOfWork.GetReadRepository<Destination>().GetAllAsync();

            List<GetAllDestinationsQueryResponse> response = new();

            foreach (var destination in destinations)
                response.Add(new GetAllDestinationsQueryResponse
                {   
                    Name = destination.Name,
                    Description = destination.Description,
                    Latitude = destination.Latitude,
                    Longitude = destination.Longitude
                });

            return response;
        }
    }
}
