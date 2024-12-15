namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class RoomImage
    {
        public int RoomImageId { get; set; }
        public int RoomId { get; set; }
        public string ImagePath { get; set; } = string.Empty;
    }
}
