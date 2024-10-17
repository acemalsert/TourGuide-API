using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TourGuide.Application.Features.Categories.Queries.GetAllCategories;
using TourGuide.Application.Features.Categories.Queries.GetCategory;
using TourGuide.Application.Features.Destinations.Queries.GetDestination;

namespace TourGuide.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await mediator.Send(new GetAllCategoriesQueryRequest());

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCategoryById(int id)
        {
            var response = await mediator.Send(new GetCategoryByIdQueryRequest { Id = id });
            return Ok(response);
        }

    }
}
