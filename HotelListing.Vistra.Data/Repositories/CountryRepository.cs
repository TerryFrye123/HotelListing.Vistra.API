using HotelListing.Vistra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Vistra.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly HotelListingDbContext dbContext;

        public CountryRepository(HotelListingDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new NullReferenceException(nameof(dbContext));
        }
        public async Task<IEnumerable<Country>> GetAsync()
        {
            var response = await dbContext.Countries.ToListAsync();
            return response;
        }
    }
}
