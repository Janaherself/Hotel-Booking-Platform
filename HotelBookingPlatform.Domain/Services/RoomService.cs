using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class RoomService(IRoomRepository roomRepository, IMapper mapper, ILogger<RoomService> logger) 
        : Service<RoomEntity, Room>(roomRepository, mapper, logger), IRoomService
    {
        public async Task<IEnumerable<RoomEntity>> SearchByAdultCapacityAsync(int adults)
        {
            logger.LogInformation("Calling SearchByAdultCapacityAsync method on room repository..");
            var rooms = await roomRepository.SearchByAdultCapacityAsync(adults);
            return _mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }

        public async Task<IEnumerable<RoomEntity>> SearchByChildrenCapacityAsync(int children)
        {
            logger.LogInformation("Calling SearchByChildrenCapacityAsync method on room repository..");
            var rooms = await roomRepository.SearchByChildrenCapacityAsync(children);
            return _mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }

        public async Task<IEnumerable<RoomEntity>> SearchByPriceAsync(decimal price)
        {
            logger.LogInformation("Calling SearchByPriceAsync method on room repository..");
            var rooms = await roomRepository.SearchByPriceAsync(price);
            return _mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }

        public async Task<IEnumerable<RoomEntity>> SearchByTypeAsync(string type)
        {
            logger.LogInformation("Calling SearchByTypeAsync method on room repository..");
            var rooms = await roomRepository.SearchByTypeAsync(type);
            return _mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }
    }
}
