using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class BookingRepository(AppDbContext context) : Repository<Booking>(context), IBookinglRepository
    {
        public async Task<IEnumerable<Hotel>> GetRecentlyVisitedHotelsAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> GetTopVisitedCitiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
