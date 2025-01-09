namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class ReviewEntity
    {
        public int? ReviewId { get; set; }
        public int? UserId { get; set; }
        public int? HotelId { get; set; }
        public string? ReviewText { get; set; }
        public bool? IsConfirmedBooking { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
