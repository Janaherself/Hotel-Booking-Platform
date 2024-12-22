using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Task<IEnumerable<Hotel>> SearchByRatingAsync(float rating);
        Task<IEnumerable<Hotel>> SearchByAmenitiesAsync(string amenities);
        Task<IEnumerable<Hotel>> SearchByCityAsync(string city);
    }
}
