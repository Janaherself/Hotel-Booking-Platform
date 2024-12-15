using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Hotel : AuditEntity
    {
        public int HotelId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Rating { get; set; }
        public string Amenities { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public List<Room> Rooms { get; set; } = [];
        public List<Review> Reviews { get; set; } = [];
        public List<HotelImage> Images { get; set; } = [];
        public List<FeaturedDeal> Deals { get; set; } = [];
    }
}
