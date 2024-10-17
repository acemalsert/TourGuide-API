using MediatR;
using TourGuide.Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TourGuide.Application.Features.Destinations.Queries.GetAllDestinations;

namespace TourGuide.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, IList<GetAllCategoriesQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetAllCategoriesQueryResponse>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await unitOfWork.GetReadRepository<Category>().Find(category => category.IsDeleted == false).ToListAsync();
            // TODO : Automapper kullanılmalı
            //var response = mapper.Map<IList<GetAllCategoriesQueryResponse>>(categories);
            List<GetAllCategoriesQueryResponse> response = new();

            foreach (var category in categories)
                response.Add(new GetAllCategoriesQueryResponse
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                });
            return response;
        }
    }
}
