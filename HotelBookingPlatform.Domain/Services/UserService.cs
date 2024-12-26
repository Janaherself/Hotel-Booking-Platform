using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class UserService(IUserRepository userRepository, IMapper mapper, IPasswordService passwordService, ITokenService tokenService) 
        : Service<UserEntity, User>(userRepository, mapper), IUserService
    {
        public async Task<string?> LoginAsync(string email, string password, string role)
        {
            var user = await userRepository.GetByEmailAsync(email);
            if (user == null)
            {
                //logger.LogInformation("User with email {@email} is not found.", email);
                return null;
            }
            if (!passwordService.VerifyPassword(password, user.PasswordHash))
            {
                //logger.LogInformation("Invalid Password for user with email {@email}", email);
                return null;
            }

            var token = tokenService.GenerateToken(email, role);

            return token;
        }

        public async Task<string?> RegisterAsync(string email, string password, string role)
        {
            if (await userRepository.GetByEmailAsync(email) != null)
            {
                //logger.LogInformation("User with email {@email} already exists.", email);
                return null;
            }

            var hashedPassword = passwordService.HashPassword(password);
            if (await userRepository.RegisterAsync(email, hashedPassword))
            {
                var token = tokenService.GenerateToken(email, role);
                return token;
            }

            return null;
        }
    }
}
