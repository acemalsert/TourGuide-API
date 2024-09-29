using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using SendGrid.Helpers.Errors.Model;
using TourGuide.Application.Interfaces.AutoMapper;

namespace TourGuide.Application.Features.Destinations.Commands.UpdateDestination
{
    internal class UpdateDestinationCommandHandler : IRequestHandler<UpdateDestinationCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateDestinationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDestinationCommandRequest request, CancellationToken cancellationToken)
        {
            var destination = await unitOfWork.GetReadRepository<Destination>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            if (destination == null)
            {
                throw new NotFoundException(nameof(Destination));
            }

            destination.Name = request.Name;
            destination.Description = request.Description;
            //destination.Location = request.Location;
            //destination.Latitude = request.Latitude;
            //destination.Longitude = request.Longitude;
            //destination.OpeningTime = request.OpeningTime;
            //destination.ClosingTime = request.ClosingTime;
            //destination.TicketPrice = request.TicketPrice;
            //destination.ImageUrl = request.ImageUrl;
            //destination.CategoryId = request.CategoryId;

            await unitOfWork.GetWriteRepository<Destination>().UpdateAsync(destination);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
    
}
