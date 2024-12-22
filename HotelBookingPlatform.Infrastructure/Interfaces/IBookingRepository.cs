using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IBookinglRepository : IRepository<Booking>
    {
        Task<IEnumerable<Hotel>> GetRecentlyVisitedHotelsAsync(int userId);
        Task<IEnumerable<City>> GetTopVisitedCitiesAsync();
    }
}
