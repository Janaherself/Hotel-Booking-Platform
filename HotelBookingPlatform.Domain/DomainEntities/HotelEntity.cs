namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class HotelEntity
    {
        public int? HotelId { get; set; }
        public string? Name { get; set; }
        public float? Rating { get; set; }
        public string? Amenities { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
