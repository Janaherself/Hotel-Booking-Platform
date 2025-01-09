using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class User : AuditEntity
    {
        public int? UserId { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber {  get; set; }
        public string? Location { get; set; }
        public string? Role { get; set; }
        public List<Booking>? Bookings { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
