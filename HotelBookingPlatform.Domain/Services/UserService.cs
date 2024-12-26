using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class UserService(
        IUserRepository userRepository,
        IMapper mapper,
        IPasswordService passwordService,
        ITokenService tokenService, 
        IRoleService roleService) 
        : Service<UserEntity, User>(userRepository, mapper), IUserService
    {
        public async Task<string?> LoginAsync(LoginEntity loginEntity)
        {
            var user = await userRepository.GetByEmailAsync(loginEntity.Email);
            if (user == null)
            {
                //logger.LogInformation("User with email {@email} is not found.", email);
                return null;
            }
            if (!passwordService.VerifyPassword(loginEntity.Password, user.PasswordHash))
            {
                //logger.LogInformation("Invalid Password for user with email {@email}", email);
                return null;
            }

            var token = tokenService.GenerateToken(user.Email, user.Role);

            return token;
        }

        public async Task<string?> RegisterAsync(LoginEntity loginEntity)
        {
            if (await userRepository.GetByEmailAsync(loginEntity.Email) != null)
            {
                //logger.LogInformation("User with email {@email} already exists.", email);
                return null;
            }

            var hashedPassword = passwordService.HashPassword(loginEntity.Password);

            var role = roleService.AssignRole(loginEntity.Email);

            var user = await userRepository.RegisterAsync(loginEntity.Password, hashedPassword, role);

            if (user != null)
            {
                var token = tokenService.GenerateToken(user.Email, user.Role);
                return token;
            }

            return null;
        }
    }
}
