using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class BookingRepository(AppDbContext context, ILogger<BookingRepository> logger) 
        : Repository<Booking>(context, logger), IBookingRepository
    {
        public async Task<IEnumerable<Hotel?>> GetRecentlyVisitedHotelsAsync(int? userId)
        {
            logger.LogInformation("Getting recently visited hotels for user with Id {Id}..", userId);
            var recentlyVisitedHotels = await _dbSet
            .Where(b => b.UserId == userId)
            .OrderByDescending(b => b.CheckOutDate)
            .SelectMany(b => b.Rooms!)
            .Select(r => r.Hotel)
            .Distinct()
            .Take(5)
            .ToListAsync();

            return recentlyVisitedHotels;
        }

        public async Task<IEnumerable<City?>> GetTopVisitedCitiesAsync()
        {
            logger.LogInformation("Getting top visited cities in the platform..");
            var topCities = await _dbSet
            .SelectMany(b => b.Rooms!)
            .Select(r => r.Hotel)
            .GroupBy(h => h!.City)
            .OrderByDescending(group => group.Count())
            .Take(5)
            .Select(group => group.Key)
            .ToListAsync();

            return topCities;
        }

        public override async Task<List<Booking>> GetAllAsync(int pageSize = 6, int pageNumber = 1)
        {
            logger.LogInformation("Getting {PageSize} items from page {PageNumber} of bookings..", pageSize, pageNumber);
            return await _dbSet
                .Include(b => b.Rooms)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public void AddBooking(Booking booking)
        {
            logger.LogInformation("Waiting for context to attach rooms of booking with id {BookingId}..", booking.BookingId);
            _context.AttachRange(booking.Rooms!);

            logger.LogInformation("Calling Add method on the base repository..");
            base.Add(booking);
        }

        public void UpdateBooking(Booking booking)
        {
            if (booking.Rooms != null)
            {  
                logger.LogInformation("Waiting for context to attach rooms of booking with id {BookingId}..", booking.BookingId);
                _context.AttachRange(booking.Rooms);
            }
            
            logger.LogInformation("Calling Update method on the base repository..");
            base.Update(booking);
        }
    }
}
