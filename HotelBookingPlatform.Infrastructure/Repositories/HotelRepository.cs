using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class HotelRepository(AppDbContext context, ILogger<HotelRepository> logger) 
        : Repository<Hotel>(context, logger), IHotelRepository
    {
        public async Task<IEnumerable<Hotel>> SearchByAmenitiesAsync(string amenities)
        {
            logger.LogInformation("Searching hotels by amenity..");
            return await _dbSet.Where(h => h.Amenities!.Contains(amenities)).ToListAsync();
        }

        public async Task<IEnumerable<Hotel>> SearchByCityAsync(string city)
        {
            logger.LogInformation("Searching hotels by city..");
            return await _dbSet.Where(h => h.City!.Name!.Contains(city)).ToListAsync();
        }

        public async Task<IEnumerable<Hotel>> SearchByRatingAsync(float rating)
        {
            logger.LogInformation("Searching hotels by rating..");
            return await _dbSet.Where(h => h.Rating >= rating).ToListAsync();
        }
    }
}
