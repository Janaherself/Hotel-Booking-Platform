using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Exceptions;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class BookingService(IBookinglRepository bookingRepository,IRoomRepository roomRepository, IMapper mapper, ILogger<BookingService> logger)
        : Service<BookingEntity, Booking>(bookingRepository, mapper, logger), IBookingService
    {
        public async Task<IEnumerable<HotelEntity>> GetRecentlyVisitedHotelsAsync(int userId)
        {
            logger.LogInformation("Calling GetRecentlyVisitedHotelsAsync method on booking repository..");
            var hotels = await bookingRepository.GetRecentlyVisitedHotelsAsync(userId);
            return _mapper.Map<IEnumerable<HotelEntity>>(hotels);
        }

        public async Task<IEnumerable<CityEntity>> GetTopVisitedCitiesAsync()
        {
            logger.LogInformation("Calling GetTopVisitedCitiesAsync method on booking repository..");
            var cities = await bookingRepository.GetTopVisitedCitiesAsync();
            return _mapper.Map<IEnumerable<CityEntity>>(cities);
        }

        public override async void Add(BookingEntity bookingEntity)
        {
            var rooms = await roomRepository.GetRoomsById(bookingEntity.RoomIds);
            if (rooms.Count() != bookingEntity.RoomIds.Count)
            {
                logger.LogError("One or more rooms have incorrect IDs.");
                throw new InvalidRoomIdException();
            }

            bookingEntity.Rooms = _mapper.Map<List<RoomEntity>>(rooms);

            logger.LogInformation("Calling the Add method on the base service..");
            base.Add(bookingEntity);
        }

        public override async Task<bool> UpdateAsync(int id, BookingEntity bookingEntity)
        {
            var rooms = await roomRepository.GetRoomsById(bookingEntity.RoomIds);
            if (rooms.Count() != bookingEntity.RoomIds.Count)
            {
                logger.LogError("One or more rooms have incorrect IDs.");
                throw new InvalidOperationException();
            }

            bookingEntity.Rooms = _mapper.Map<List<RoomEntity>>(rooms);

            logger.LogInformation("Calling the Update method on the base service..");
            return await base.UpdateAsync(id, bookingEntity);
        }
    }
}
