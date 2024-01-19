using HotelListing.Vistra.API.Models.Dto;

namespace HotelListing.API.Vistra.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<GetCountryDto>> GetCountryAsync();
    }
}
