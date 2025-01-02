using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class City : AuditEntity
    {
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PostOffice { get; set; } = string.Empty;
        public int NumberOfHotels { get; set; }
        public string Country { get; set; } = string.Empty;
        public List<Hotel> Hotels { get; set; } = [];
    }
}
