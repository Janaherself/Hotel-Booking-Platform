using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IBookingService : IService<BookingEntity, Booking>
    {
        Task<IEnumerable<HotelEntity>> GetRecentlyVisitedHotelsAsync(int userId);
        Task<IEnumerable<CityEntity>> GetTopVisitedCitiesAsync();
        new void Add(BookingEntity bookingEntity);
        new Task<bool> UpdateAsync(int id, BookingEntity bookingEntity);
    }
}
