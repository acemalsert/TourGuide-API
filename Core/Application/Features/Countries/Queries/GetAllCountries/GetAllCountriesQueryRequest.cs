using MediatR;

namespace TourGuide.Application.Features.Countries.Queries.GetAllCountries
{
    public class GetAllCountriesQueryRequest : IRequest<IList<GetAllCountriesQueryReponse>>
    {
        public GetAllCountriesQueryRequest()
        {
            
        }
    }
}
