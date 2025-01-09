namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class RoomEntity
    {
        public int? RoomId { get; set; }
        public int? HotelId { get; set; }
        public string? Number { get; set; }
        public decimal? Price { get; set; }
        public int? AdultsCapacity { get; set; }
        public int? ChildrenCapacity { get; set; }
        public string? Type { get; set; }
        public bool? IsAvailable { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
