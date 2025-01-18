using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IBookingService : IService<BookingEntity, Booking>
    {
        Task<IEnumerable<HotelEntity>> GetRecentlyVisitedHotelsAsync(int userId);
        Task<IEnumerable<CityEntity>> GetTopVisitedCitiesAsync();
        new Task<BookingEntity> GetByIdAsync(int id);
        new Task<IEnumerable<BookingEntity>> GetAllAsync(int pageSize, int pageNumer);
        Task AddAsync(BookingEntity bookingEntity, int userId);
        Task<bool> UpdateAsync(int id, BookingEntity bookingEntity, int userId);
        Task<bool> DeleteAsync(int bookingId, int userId);
    }
}
