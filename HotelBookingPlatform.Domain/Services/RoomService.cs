using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class RoomService(IRoomRepository roomRepository, IMapper mapper) : Service<RoomEntity, Room>(roomRepository, mapper), IRoomService
    {
        public async Task<IEnumerable<RoomEntity>> SearchByAdultCapacityAsync(int adults)
        {
            var rooms = await roomRepository.SearchByAdultCapacityAsync(adults);
            return mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }

        public async Task<IEnumerable<RoomEntity>> SearchByChildrenCapacityAsync(int children)
        {
            var rooms = await roomRepository.SearchByChildrenCapacityAsync(children);
            return mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }

        public async Task<IEnumerable<RoomEntity>> SearchByPriceAsync(decimal price)
        {
            var rooms = await roomRepository.SearchByPriceAsync(price);
            return mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }

        public async Task<IEnumerable<RoomEntity>> SearchByTypeAsync(string type)
        {
            var rooms = await roomRepository.SearchByTypeAsync(type);
            return mapper.Map<IEnumerable<RoomEntity>>(rooms);
        }
    }
}
