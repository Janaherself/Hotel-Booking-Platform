using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IRoomService : IService<RoomEntity, Room>
    {
        Task<IEnumerable<RoomEntity>> SearchByPriceAsync(decimal price);
        Task<IEnumerable<RoomEntity>> SearchByAdultCapacityAsync(int adults);
        Task<IEnumerable<RoomEntity>> SearchByChildrenCapacityAsync(int children);
        Task<IEnumerable<RoomEntity>> SearchByTypeAsync(string type);
    }
}
