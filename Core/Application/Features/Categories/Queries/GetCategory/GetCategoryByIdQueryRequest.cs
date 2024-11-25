using MediatR;


namespace TourGuide.Application.Features.Categories.Queries.GetCategory
{
    public class GetCategoryByIdQueryRequest : IRequest<GetCategoryByIdQueryReponse>
    {
        public int Id { get; set; }
    }
}
