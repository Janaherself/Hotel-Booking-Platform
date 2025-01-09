using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class Hotel : AuditEntity
    {
        public int? HotelId { get; set; }
        public int? CityId { get; set; }
        public string? Name { get; set; }
        public float? Rating { get; set; }
        public string? Amenities { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public string? LocationOnMap {  get; set; }
        public City? City { get; set; }
        public List<Room>? Rooms { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<HotelImage>? Images { get; set; }
        public List<FeaturedDeal>? Deals { get; set; }
    }
}
