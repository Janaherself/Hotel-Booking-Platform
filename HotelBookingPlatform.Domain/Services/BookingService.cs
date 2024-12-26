using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class BookingService(IBookinglRepository bookingRepository, IMapper mapper, ILogger<BookingService> logger)
        : Service<BookingEntity, Booking>(bookingRepository, mapper, logger), IBookingService
    {
        public async Task<IEnumerable<HotelEntity>> GetRecentlyVisitedHotelsAsync(int userId)
        {
            logger.LogInformation("Calling GetRecentlyVisitedHotelsAsync method on booking repository..");
            var hotels = await bookingRepository.GetRecentlyVisitedHotelsAsync(userId);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<CityEntity>> GetTopVisitedCitiesAsync()
        {
            logger.LogInformation("Calling GetTopVisitedCitiesAsync method on booking repository..");
            var cities = await bookingRepository.GetTopVisitedCitiesAsync();
            return mapper.Map<IEnumerable<CityEntity>>(cities);
        }
    }
}
