namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class HotelImageEntity
    {
        public int HotelImageId { get; set; }
        public int HotelId { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}
