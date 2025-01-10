using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Exceptions;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class BookingService(IBookingRepository bookingRepository,IRoomRepository roomRepository, IMapper mapper, ILogger<BookingService> logger)
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

        public override async Task<IEnumerable<BookingEntity>> GetAllAsync(int pageSize = 6, int pageNumer = 1)
        {
            logger.LogInformation("Calling GetAllAsync method on the booking repository..");
            var entities = await bookingRepository.GetAllAsync(pageSize, pageNumer);
            return _mapper.Map<IEnumerable<BookingEntity>>(entities);
        }

        public async Task AddAsync(BookingEntity bookingEntity, int userId)
        {
            var rooms = await roomRepository.GetRoomsById(bookingEntity.RoomIds!);
            if (rooms.Count != bookingEntity.RoomIds!.Count)
            {
                logger.LogError("One or more rooms have incorrect IDs.");
                throw new InvalidRoomIdException();
            }

            var booking = _mapper.Map<Booking>(bookingEntity);

            booking.Rooms = rooms;
            booking.UserId = userId;

            logger.LogInformation("Calling AddAsync method on BookingRepository..");
            bookingRepository.AddBooking(booking);
        }

        public async Task<bool> UpdateAsync(int bookingId, BookingEntity bookingEntity, int userId)
        {
            var booking = await bookingRepository.GetByIdAsync(bookingId) ?? throw new ItemNotFoundException();

            if (booking.UserId != userId)
            {
                return false;
            }

            if (bookingEntity.RoomIds != null && bookingEntity.RoomIds.Count != 0)
            {
                var rooms = await roomRepository.GetRoomsById(bookingEntity.RoomIds);
                if (rooms.Count != bookingEntity.RoomIds.Count)
                {
                    logger.LogError("One or more rooms have incorrect IDs.");
                    throw new InvalidRoomIdException();
                }

                booking.Rooms = rooms;
            }

            _mapper.Map(bookingEntity, booking);

            logger.LogInformation("Calling UpdateBooking method on BookingRepository..");
            bookingRepository.UpdateBooking(booking);
            return true;
        }
    }
}
