using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class UserService(
        IUserRepository userRepository,
        IMapper mapper,
        IPasswordService passwordService,
        ITokenService tokenService, 
        IRoleService roleService,
        ILogger<UserService> logger) 
        : Service<UserEntity, User>(userRepository, mapper, logger), IUserService
    {
        public async Task<string?> LoginAsync(LoginEntity loginEntity)
        {
            logger.LogInformation("Searching for user with email {Email} in database through user repository..", loginEntity.Email);

            var user = await userRepository.GetByEmailAsync(loginEntity.Email);
            if (user == null)
            {
                logger.LogInformation("User with email {Email} is not found.", loginEntity.Email);
                return null;
            }
            if (!passwordService.VerifyPassword(loginEntity.Password, user.PasswordHash))
            {
                logger.LogInformation("Invalid Password for user with email {Email}.", loginEntity.Email);
                return null;
            }

            logger.LogInformation("User with email {Email} is authenticated.", loginEntity.Email);

            var token = tokenService.GenerateToken(user.Email, user.Role);

            return token;
        }

        public async Task<string?> RegisterAsync(LoginEntity loginEntity)
        {
            logger.LogInformation("Registering a new user with email {@email}..", loginEntity.Email);

            if (await userRepository.GetByEmailAsync(loginEntity.Email) != null)
            {
                logger.LogInformation("User with email {Email} already exists.", loginEntity.Email);
                return null;
            }

            var hashedPassword = passwordService.HashPassword(loginEntity.Password);

            var role = roleService.AssignRole(loginEntity.Email);

            var user = await userRepository.RegisterAsync(loginEntity.Password, hashedPassword, role);

            if (user != null)
            {
                logger.LogInformation("A new user with email {Email} has been successfully registered.", loginEntity.Email);
                var token = tokenService.GenerateToken(user.Email, user.Role);
                return token;
            }

            logger.LogError("The register method on user repository encountered an error while trying to register user with email {Email}."
                , loginEntity.Email);

            return null;
        }
    }
}
