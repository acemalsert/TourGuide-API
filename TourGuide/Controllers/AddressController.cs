using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

    }
}
