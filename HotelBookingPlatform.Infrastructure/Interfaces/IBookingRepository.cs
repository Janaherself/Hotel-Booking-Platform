using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<IEnumerable<Hotel?>> GetRecentlyVisitedHotelsAsync(int userId);
        Task<IEnumerable<City?>> GetTopVisitedCitiesAsync();
    }
}
