using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace TourGuide.Application.Features.Destinations.Queries.GetDestination
{
    public class GetDestinationByIdQueryHandler : IRequestHandler<GetDestinationByIdQueryRequest, GetDestinationByIdQueryResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetDestinationByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetDestinationByIdQueryResponse> Handle(GetDestinationByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var destination = unitOfWork.GetReadRepository<Destination>().Find(x => x.Id == request.Id && x.IsDeleted == false).FirstOrDefault();

            if (destination == null)
            {
                return null; 
            }

            return new GetDestinationByIdQueryResponse
            {
                Id = destination.Id,
                Name = destination.Name,
                Description = destination.Description,
                Latitude = destination.Latitude,
                Longitude = destination.Longitude
            };
        }
    }

}
