using HotelBookingPlatform.Domain.Interfaces;

namespace HotelBookingPlatform.Domain.Services
{
    public class RoleService : IRoleService
    {
        public string AssignRole(string email)
        {
            var adminEmails = new List<string>
            {
                "admin@admin.com",
                "jana@admin.com"
            };

            var role = adminEmails.Contains(email) ? "Admin" : "User";

            return role;
        }
    }
}
