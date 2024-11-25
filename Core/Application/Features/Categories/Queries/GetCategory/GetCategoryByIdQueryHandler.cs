using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using TourGuide.Application.Features.Categories.Queries.GetCategory;

namespace TourGuide.Application.Features.Destinations.Queries.GetDestination
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, GetCategoryByIdQueryReponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetCategoryByIdQueryReponse> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var category = unitOfWork.GetReadRepository<Category>().Find(x => x.Id == request.Id && x.IsDeleted == false).FirstOrDefault();

            if (category == null)
            {
                return null;
            }

            // TODO : Automapper kullanılmalı
            return new GetCategoryByIdQueryReponse
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
            };
        }
    }

}
