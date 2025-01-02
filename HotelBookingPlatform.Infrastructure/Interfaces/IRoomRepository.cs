using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IRoomRepository : IRepository<Room>
    {
        Task<IEnumerable<Room>> SearchByPriceAsync(decimal price);
        Task<IEnumerable<Room>> SearchByAdultCapacityAsync(int adults);
        Task<IEnumerable<Room>> SearchByChildrenCapacityAsync(int children);
        Task<IEnumerable<Room>> SearchByTypeAsync(string type);
        Task<List<Room>> GetRoomsById(IEnumerable<int> roomIds);
    }
}
