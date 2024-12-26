using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext context, ILogger<UserRepository> logger) : Repository<User>(context, logger), IUserRepository
    {
        public async Task<User?> GetByEmailAsync(string email)
        {
            logger.LogInformation("Search users by email.");
            return await base._dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> RegisterAsync(string email, string hashedPassword)
        {
            var user = new User
            {
                Email = email,
                PasswordHash = hashedPassword,
                Role = email == "admin@admin.com" ? "Admin" : "User"
            };

            try
            {
                var dbUser = await base.AddAsync(user);
                await base.SaveAsync();
                logger.LogInformation("User with email {Email} has successfully registered.", email);
                return dbUser;
            }
            catch (DbUpdateException ex)
            {
                logger.LogInformation(ex, "User with email {Email} couldn't be registered.", email);

            }

            return null;
        }
    }
}
