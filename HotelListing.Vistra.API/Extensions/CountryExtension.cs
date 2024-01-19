using HotelListing.Vistra.API.Models.Dto;
using HotelListing.Vistra.Data.Context;

namespace HotelListing.API.Vistra.Extensions
{
    public static class CountryExtension
    {
        public static IEnumerable<GetCountryDto> ToGetListCountryDto(this IEnumerable<Country> countriesDomain)
        {

            var countries = new List<GetCountryDto>();
            foreach (var country in countriesDomain)
            {
                var countryDto = new GetCountryDto()
                {
                    Name = country.Name,
                    ShortName = country.ShortName
                };
                countries.Add(countryDto);

            }
            return countries;
        }
    }
}
