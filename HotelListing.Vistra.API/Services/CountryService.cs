using HotelListing.API.Vistra.Extensions;
using HotelListing.Vistra.API.Models.Dto;
using HotelListing.Vistra.Repositories;

namespace HotelListing.API.Vistra.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            this._countryRepository = countryRepository ?? throw new ArgumentNullException(nameof(countryRepository));
        }
        public async Task<IEnumerable<GetCountryDto>> GetCountryAsync()
        {
            var response = await _countryRepository.GetAsync();
            return response.ToGetListCountryDto();

        }
    }
}
