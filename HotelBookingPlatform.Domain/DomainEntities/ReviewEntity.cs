namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class ReviewEntity
    {
        public int UserId { get; set; }
        public int HotelId { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public bool IsConfirmedBooking { get; set; }
    }
}
