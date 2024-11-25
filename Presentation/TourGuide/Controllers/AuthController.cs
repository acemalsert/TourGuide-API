using MediatR;
using Microsoft.AspNetCore.Mvc;
using TourGuide.Application.Features.Auth.Commands.Login;
using TourGuide.Application.Features.Auth.Commands.RefreshToken;
using TourGuide.Application.Features.Auth.Commands.Register;
using TourGuide.Application.Features.Auth.Commands.Revoke;
using TourGuide.Application.Features.Auth.Commands.RevokeAll;
using TourGuide.Application.Features.Auth.Queries.GetAllGuides;
using TourGuide.Application.Features.Auth.Queries.GetAllUsers;
using TourGuide.Application.Features.Auth.Queries.GetGuideById;
using TourGuide.Application.Features.Auth.Queries.GetUserById;


namespace TourGuide.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            await mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        public async Task<IActionResult> Revoke(RevokeCommandRequest request)
        {
            await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPost]
        public async Task<IActionResult> RevokeAll()
        {
            await mediator.Send(new RevokeAllCommandRequest());
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await mediator.Send(new GetAllUsersQueryRequest());
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGuides()
        {
            var response = await mediator.Send(new GetAllGuidesQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuideById(Guid id)
        {
            var response = await mediator.Send(new GetGuideByIdQueryRequest { Id = id});
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var response = await mediator.Send(new GetUserByIdQueryRequest { Id = id });
            return Ok(response);
        }
    }
}
