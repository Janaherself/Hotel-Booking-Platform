using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class HotelRepository(AppDbContext context) : Repository<Hotel>(context), IHotelRepository
    {
        public async Task<IEnumerable<Hotel>> SearchByAmenitiesAsync(string amenities)
        {
            return await _dbSet.Where(h => h.Amenities.Contains(amenities)).ToListAsync();
        }

        public async Task<IEnumerable<Hotel>> SearchByCityAsync(string city)
        {
            return await _dbSet.Where(h => h.City!.Name.Contains(city)).ToListAsync();
        }

        public async Task<IEnumerable<Hotel>> SearchByRatingAsync(float rating)
        {
            return await _dbSet.Where(h => h.Rating >= rating).ToListAsync();
        }
    }
}
