using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class BookingRepository(AppDbContext context) : Repository<Booking>(context), IBookinglRepository
    {
        public async Task<IEnumerable<Hotel?>> GetRecentlyVisitedHotelsAsync(int userId)
        {
            var recentlyVisitedHotels = await _dbSet
            .Where(b => b.UserId == userId)
            .OrderByDescending(b => b.CheckOutDate)
            .SelectMany(b => b.Rooms)
            .Select(r => r.Hotel)
            .Distinct()
            .Take(5)
            .ToListAsync();

            return recentlyVisitedHotels;
        }

        public async Task<IEnumerable<City?>> GetTopVisitedCitiesAsync()
        {
            var topCities = await _dbSet
            .SelectMany(b => b.Rooms)
            .Select(r => r.Hotel)
            .GroupBy(h => h!.City)
            .OrderByDescending(group => group.Count())
            .Take(5)
            .Select(group => group.Key)
            .ToListAsync();

            return topCities;

        }
    }
}
