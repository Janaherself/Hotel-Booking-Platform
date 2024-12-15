using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class FeaturedDeal : AuditEntity
    {
        public int FeaturedDealId { get; set; }
        public int HotelId { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndsDate { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
