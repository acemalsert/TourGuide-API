﻿using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TourGuide.Application.Features.Destinations.Commands.CreateDestination
{
    public class CreateDestinationCommandHandler : IRequestHandler<CreateDestinationCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateDestinationCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateDestinationCommandRequest request, CancellationToken cancellationToken)
        {
            Destination destination = new Destination(
                request.Name,
                request.Description,
                request.OpeningTime,
                request.ClosingTime,
                request.TicketPrice,
                request.ImageData,
                request.CategoryId 
            );

            IList<Destination> destinations = await unitOfWork.GetReadRepository<Destination>().GetAllAsync();

            if(destinations.Any(x => x.Name == request.Name))
            {
                throw new Exception();
            }
            

            await unitOfWork.GetWriteRepository<Destination>().AddAsync(destination);

            if (await unitOfWork.SaveAsync() > 0)
            {
                await unitOfWork.SaveAsync();
            }

            return Unit.Value;
        }
    }
}
