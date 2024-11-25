using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
            var destinations = await unitOfWork.GetReadRepository<Destination>().Find(destination => destination.IsDeleted == false).ToListAsync();

            List<GetAllDestinationsQueryResponse> response = new();

            foreach (var destination in destinations)
                response.Add(new GetAllDestinationsQueryResponse
                {   
                    Id = destination.Id.ToString(),
                    Name = destination.Name,
                    Description = destination.Description,
                    ImageData = destination.ImageData,
                    
                    //Latitude = destination.Latitude,
                    //Longitude = destination.Longitude
                });

            return response;
        }
    }
}
