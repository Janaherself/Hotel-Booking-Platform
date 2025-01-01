using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure.Tests.UnitTests
{
    public class InMemoryDbContextFactory
    {
        public AppDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new AppDbContext(options);

            return context;
        }
    }
}
