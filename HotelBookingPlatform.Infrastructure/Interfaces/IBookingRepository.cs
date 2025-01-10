using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<IEnumerable<Hotel?>> GetRecentlyVisitedHotelsAsync(int? userId);
        Task<IEnumerable<City?>> GetTopVisitedCitiesAsync();
        new Task<Booking?> GetByIdAsync(int id);
        new Task<List<Booking>> GetAllAsync(int pageSize, int pageNumber);
        void AddBooking(Booking booking);
        void UpdateBooking(Booking booking);
    }
}
