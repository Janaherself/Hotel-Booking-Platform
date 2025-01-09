using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Room : AuditEntity
    {
        public int? RoomId { get; set; }
        public int? HotelId { get; set; }
        public string? Number { get; set; }
        public decimal? Price { get; set; }
        public int? AdultsCapacity { get; set; }
        public int? ChildrenCapacity { get; set; }
        public string? Type { get; set; }
        public bool? IsAvailable { get; set; }
        public Hotel? Hotel { get; set; }
        public List<Booking>? Bookings { get; set; }
        public List<RoomImage>? Images { get; set; }
    }
}
