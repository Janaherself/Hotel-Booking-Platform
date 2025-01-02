using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class HotelImage : AuditEntity
    {
        public int HotelImageId { get; set; }
        public int HotelId { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}
