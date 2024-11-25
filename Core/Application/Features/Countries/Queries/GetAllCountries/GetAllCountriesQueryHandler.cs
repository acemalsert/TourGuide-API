using Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Countries.Queries.GetAllCountries
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQueryRequest, IList<GetAllCountriesQueryReponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        public GetAllCountriesQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllCountriesQueryReponse>> Handle(GetAllCountriesQueryRequest request, CancellationToken cancellationToken)
        {
            {
                var countries = await unitOfWork.GetReadRepository<Country>().Find(country => country.IsDeleted == false).ToListAsync();

                List<GetAllCountriesQueryReponse> response = new();

                foreach (var country in countries)
                {
                    response.Add(new GetAllCountriesQueryReponse
                    {
                        Id = country.Id,
                        CountryName = country.CountryName
                    });
                }

                return response;
            }
        }
    }
}