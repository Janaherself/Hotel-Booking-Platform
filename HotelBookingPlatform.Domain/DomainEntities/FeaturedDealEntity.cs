namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class FeaturedDealEntity
    {
        public int HotelId { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndsDate { get; set; }
    }
}
