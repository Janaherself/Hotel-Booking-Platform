using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelBookingPlatform.Domain.Services
{
    public class RoleService(ILogger<RoleService> logger) : IRoleService
    {
        public string AssignRole(string email)
        {
            logger.LogInformation("Assigning role to user with email {Email}", email);

            var adminEmails = new List<string>
            {
                "admin@admin.com",
                "jana@admin.com"
            };

            var role = adminEmails.Contains(email) ? "Admin" : "User";

            logger.LogInformation("User with email {Email} is assigned the role {Role}", email, role);

            return role;
        }
    }
}
