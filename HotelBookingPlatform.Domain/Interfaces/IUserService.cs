using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Infrastructure.Entities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface IUserService : IService<UserEntity, User>
    {
        Task<bool> LoginAsync(string email, string password);

        Task<bool> RegisterAsync(string email, string password);

    }
}
