using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class HotelService(IHotelRepository hotelRepository, IMapper mapper, ILogger<HotelService> logger) 
        : Service<HotelEntity, Hotel>(hotelRepository, mapper, logger), IHotelService
    {
        public async Task<IEnumerable<HotelEntity>> SearchByAmenitiesAsync(string amenities)
        {
            logger.LogInformation("Calling SearchByAmenitiesAsync method on hotel repository..");
            var hotels = await hotelRepository.SearchByAmenitiesAsync(amenities);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<HotelEntity>> SearchByCityAsync(string city)
        {
            logger.LogInformation("Calling SearchByCityAsync method on hotel repository..");
            var hotels = await hotelRepository.SearchByCityAsync(city);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<HotelEntity>> SearchByRatingAsync(float rating)
        {
            logger.LogInformation("Calling SearchByRatingAsync method on hotel repository..");
            var hotels = await hotelRepository.SearchByRatingAsync(rating);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }
    }
}
