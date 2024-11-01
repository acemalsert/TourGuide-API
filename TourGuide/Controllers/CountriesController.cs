using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TourGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CountriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }


    }
}
