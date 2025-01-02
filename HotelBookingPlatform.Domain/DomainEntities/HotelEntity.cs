namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class HotelEntity
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Rating { get; set; }
        public string Amenities { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
