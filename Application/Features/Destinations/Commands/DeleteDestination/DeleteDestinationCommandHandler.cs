using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace TourGuide.Application.Features.Destinations.Commands.DeleteDestination
{
    internal class DeleteDestinationCommandHandler : IRequestHandler<DeleteDestinationCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteDestinationCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteDestinationCommandRequest request, CancellationToken cancellationToken)
        {
            var destination = await unitOfWork.GetReadRepository<Destination>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            destination.IsDeleted = true;

            await unitOfWork.GetWriteRepository<Destination>().UpdateAsync(destination);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
