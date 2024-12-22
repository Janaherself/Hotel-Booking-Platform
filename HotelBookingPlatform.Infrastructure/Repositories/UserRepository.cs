using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingPlatform.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext context) : Repository<User>(context), IUserRepository
    {
        public async Task<User?> GetByEmailAsync(string email)
        {
            return await base._dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<bool> RegisterAsync(string email, string hashedPassword)
        {
            var user = new User
            {
                Email = email,
                PasswordHash = hashedPassword
            };

            await base.AddAsync(user);
            await base.SaveAsync();

            return true;
        }
    }
}
