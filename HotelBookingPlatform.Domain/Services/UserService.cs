using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using static HotelBookingPlatform.Domain.Services.PasswordService;

namespace HotelBookingPlatform.Domain.Services
{
    public class UserService(IUserRepository userRepository, IMapper mapper) : Service<UserEntity, User>(userRepository, mapper), IUserService
    {
        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = await userRepository.GetByEmailAsync(email);
            if (user == null)
            {
                //logger.LogInformation("User with email {@email} is not found.", email);
                return false;
            }
            if (!VerifyPassword(password, user.PasswordHash))
            {
                //logger.LogInformation("Invalid Password for user with email {@email}", email);
                return false;
            }
            // generate JWT
            return true;
        }

        public async Task<bool> RegisterAsync(string email, string password)
        {
            if (await userRepository.GetByEmailAsync(email) != null)
            {
                //logger.LogInformation("User with email {@email} already exists.", email);
                return false;
            }

            var hashedPassword = HashPassword(password);
            await userRepository.RegisterAsync(email, hashedPassword);

            // generate JWT

            return true;
        }
    }
}
