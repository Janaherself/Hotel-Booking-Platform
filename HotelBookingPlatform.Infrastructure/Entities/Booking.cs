using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Booking : AuditEntity
    {
        public int? BookingId { get; set; }
        public int? UserId { get; set; }
        public DateOnly? CheckInDate { get; set; }
        public DateOnly? CheckOutDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? Status {  get; set; }
        public User? User { get; set; }
        public List<Room>? Rooms { get; set; } = [];
    }
}
