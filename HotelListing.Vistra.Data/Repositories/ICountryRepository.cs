using HotelListing.Vistra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Vistra.Repositories
{
    public interface ICountryRepository
    {
        public Task<IEnumerable<Country>> GetAsync();
    }
}
