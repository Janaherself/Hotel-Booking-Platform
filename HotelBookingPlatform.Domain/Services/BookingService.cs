using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using HotelBookingPlatform.Infrastructure.Repositories;

namespace HotelBookingPlatform.Domain.Services
{
    public class BookingService(IBookinglRepository bookingRepository, IMapper mapper) : Service<BookingEntity, Booking>(bookingRepository, mapper), IBookingService
    {
        public async Task<IEnumerable<HotelEntity>> GetRecentlyVisitedHotelsAsync(int userId)
        {
            var hotels = await bookingRepository.GetRecentlyVisitedHotelsAsync(userId);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<CityEntity>> GetTopVisitedCitiesAsync()
        {
            var cities = await bookingRepository.GetTopVisitedCitiesAsync();
            return mapper.Map<IEnumerable<CityEntity>>(cities);
        }
    }
}
