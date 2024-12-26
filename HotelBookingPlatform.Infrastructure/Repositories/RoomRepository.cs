using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class RoomRepository(AppDbContext context, ILogger<RoomRepository> logger) : Repository<Room>(context, logger), IRoomRepository
    {
        public async Task<IEnumerable<Room>> SearchByAdultCapacityAsync(int adults)
        {
            logger.LogInformation("Search rooms by Adult capacity.");
            return await _dbSet.Where(r => r.AdultsCapacity >= adults).ToListAsync();
        }

        public async Task<IEnumerable<Room>> SearchByChildrenCapacityAsync(int children)
        {
            logger.LogInformation("Search rooms by children capacity.");
            return await _dbSet.Where(r => r.ChildrenCapacity >= children).ToListAsync();
        }

        public async Task<IEnumerable<Room>> SearchByPriceAsync(decimal price)
        {
            logger.LogInformation("Search rooms by price.");
            return await _dbSet.Where(r => r.Price <= price).ToListAsync();
        }

        public async Task<IEnumerable<Room>> SearchByTypeAsync(string type)
        {
            logger.LogInformation("Search rooms by type.");
            return await _dbSet.Where(r => r.Type.Contains(type)).ToListAsync();
        }
    }
}
