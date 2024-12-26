using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);

        Task<User?> RegisterAsync(string email, string hashedPassword);
    }
}
