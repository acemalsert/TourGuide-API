using MediatR;
using Microsoft.AspNetCore.Mvc;
using TourGuide.Application.Features.Destinations.Commands.CreateDestination;
using TourGuide.Application.Features.Destinations.Commands.DeleteDestination;
using TourGuide.Application.Features.Destinations.Commands.UpdateDestination;
using TourGuide.Application.Features.Destinations.Queries.GetAllDestinations;
using TourGuide.Application.Features.Destinations.Queries.GetDestination;

namespace TourGuide.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IMediator mediator;

        public DestinationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDestinations()
        {
            var response = await mediator.Send(new GetAllDestinationsQueryRequest());

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetDestinationById(int id)
        {
            var response = await mediator.Send(new GetDestinationByIdQueryRequest { Id = id });
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDestination(CreateDestinationCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        // TODO :  Burayı test et ve frontend ile uyumlu hale getir 
        [HttpPost]
        public async Task<IActionResult> UpdateDestination(UpdateDestinationCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteDestination(DeleteDestinationCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
    }
}
