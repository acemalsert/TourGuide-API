using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Countries.Queries.GetAllCountries
{
    public class GetAllCountriesQueryReponse
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
