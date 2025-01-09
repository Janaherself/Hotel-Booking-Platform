using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class RoomImage : AuditEntity
    {
        public int? RoomImageId { get; set; }
        public int? RoomId { get; set; }
        public string? ImagePath { get; set; }
    }
}
