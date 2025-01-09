using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Review : AuditEntity
    {
        public int? ReviewId { get; set; }
        public int? UserId { get; set; }
        public int? HotelId { get; set; }
        public string? ReviewText { get; set; }
        public bool? IsConfirmedBooking { get; set; }
    }
}
