using MediatR;
using Microsoft.AspNetCore.Mvc;
using TourGuide.Application.Features.Countries.Queries.GetAllCountries;

namespace TourGuide.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CountriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAllCountries()
        {
            var response = await mediator.Send(new GetAllCountriesQueryRequest());
            return Ok(response);
        }

    }
}
