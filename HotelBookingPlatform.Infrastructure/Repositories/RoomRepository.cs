using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class RoomRepository(AppDbContext context) : Repository<Room>(context), IRoomRepository
    {
        public async Task<IEnumerable<Room>> SearchByAdultCapacityAsync(int adults)
        {
            return await _dbSet.Where(r => r.AdultsCapacity >= adults).ToListAsync();
        }

        public async Task<IEnumerable<Room>> SearchByChildrenCapacityAsync(int children)
        {
            return await _dbSet.Where(r => r.ChildrenCapacity >= children).ToListAsync();
        }

        public async Task<IEnumerable<Room>> SearchByPriceAsync(decimal price)
        {
            return await _dbSet.Where(r => r.Price <= price).ToListAsync();
        }

        public async Task<IEnumerable<Room>> SearchByTypeAsync(string type)
        {
            return await _dbSet.Where(r => r.Type.Contains(type)).ToListAsync();
        }
    }
}
