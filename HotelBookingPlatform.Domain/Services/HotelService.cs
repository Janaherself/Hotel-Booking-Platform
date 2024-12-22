using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class HotelService(IHotelRepository hotelRepository, IMapper mapper) : Service<HotelEntity, Hotel>(hotelRepository, mapper), IHotelService
    {
        public async Task<IEnumerable<HotelEntity>> SearchByAmenitiesAsync(string amenities)
        {
            var hotels = await hotelRepository.SearchByAmenitiesAsync(amenities);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<HotelEntity>> SearchByCityAsync(string city)
        {
            var hotels = await hotelRepository.SearchByCityAsync(city);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<HotelEntity>> SearchByRatingAsync(float rating)
        {
            var hotels = await hotelRepository.SearchByRatingAsync(rating);
            return mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }
    }
}
