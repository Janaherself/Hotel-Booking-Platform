using AutoMapper;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Exceptions;
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
        public async Task<UserEntity> GetByEmailAsync(string email)
        {
            logger.LogInformation("Searching for user with email {Email} in database through user repository..", email);
            var user = await userRepository.GetByEmailAsync(email);
            if (user == null)
            {
                logger.LogInformation("User with email {Email} is not found.", email);
                throw new ItemNotFoundException($"User with email {email} was not found.");
            }

            logger.LogInformation("User with email {Email} is found.", email);
            var foundUser = _mapper.Map<UserEntity>(user);
            return foundUser;
        }

        public async Task<string?> LoginAsync(LoginEntity loginEntity)
        {

            var user = await GetByEmailAsync(loginEntity.Email);

            if (!passwordService.VerifyPassword(loginEntity.Password, user.PasswordHash))
            {
                logger.LogInformation("Invalid Password for user with email {Email}.", loginEntity.Email);
                return null;
            }

            logger.LogInformation("User with email {Email} is authenticated.", loginEntity.Email);

            var token = tokenService.GenerateToken(user.UserId, user.Email, user.Role);

            return token;
        }

        public async Task<string?> RegisterAsync(LoginEntity loginEntity)
        {
            logger.LogInformation("Registering a new user with email {@email}..", loginEntity.Email);

            if (await userRepository.GetByEmailAsync(loginEntity.Email) != null)
            {
                logger.LogError("User with email {Email} already exists.", loginEntity.Email);
                return null;
            }

            var hashedPassword = passwordService.HashPassword(loginEntity.Password);

            var role = roleService.AssignRole(loginEntity.Email);

            var isRegistered = await userRepository.RegisterAsync(loginEntity.Email, hashedPassword, role);

            if (isRegistered)
            {
                logger.LogInformation("A new user with email {Email} has been successfully registered.", loginEntity.Email);
                
                var user = await GetByEmailAsync(loginEntity.Email);
                var token = tokenService.GenerateToken(user.UserId, loginEntity.Email, role);
                return token;
            }

            logger.LogError("An error occured while trying to create a token for user with email {Email}.", loginEntity.Email);

            return null;
        }
    }
}
