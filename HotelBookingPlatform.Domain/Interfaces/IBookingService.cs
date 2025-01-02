using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IBookingService : IService<BookingEntity, Booking>
    {
        Task<IEnumerable<HotelEntity>> GetRecentlyVisitedHotelsAsync(int userId);
        Task<IEnumerable<CityEntity>> GetTopVisitedCitiesAsync();
        void Add(BookingEntity bookingEntity, int userId);
        Task<bool> UpdateAsync(int id, BookingEntity bookingEntity, int userId);
    }
}
