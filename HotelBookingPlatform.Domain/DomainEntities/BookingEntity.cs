namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class BookingEntity
    {
        public int? BookingId { get; set; }
        public int? UserId { get; set; }
        public DateOnly? CheckInDate { get; set; }
        public DateOnly? CheckOutDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? Status { get; set; }
        public UserEntity? User { get; set; }
        public List<RoomEntity>? Rooms { get; set; }
        public List<int>? RoomIds { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
