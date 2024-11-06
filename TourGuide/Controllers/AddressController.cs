using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourGuide.Application.Features.Addresses.Queries.GetAllAddresses;
using TourGuide.Application.Features.Categories.Queries.GetAllCategories;

namespace TourGuide.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator mediator;

        public AddressController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAllAddresses()
        {
            var response = await mediator.Send(new GetAllAddressesQueryRequest());

            return Ok(response);
        }

    }
}
