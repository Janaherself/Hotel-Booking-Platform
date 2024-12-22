using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IHotelService : IService<HotelEntity, Hotel>
    {
        Task<IEnumerable<HotelEntity>> SearchByRatingAsync(float rating);
        Task<IEnumerable<HotelEntity>> SearchByAmenitiesAsync(string amenities);
        Task<IEnumerable<HotelEntity>> SearchByCityAsync(string city);
    }
}
