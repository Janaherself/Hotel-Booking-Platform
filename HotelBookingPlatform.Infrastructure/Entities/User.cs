using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class User : AuditEntity
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public List<Booking> Bookings { get; set; } = [];
        public List<Review> Reviews { get; set; } = [];
    }
}
