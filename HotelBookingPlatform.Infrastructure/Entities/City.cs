using HotelBookingPlatform.Infrastructure.Interfaces;

namespace HotelBookingPlatform.Infrastructure.Entities
{
    public class City : AuditEntity
    {
        public int? CityId { get; set; }
        public string? Name { get; set; }
        public string? PostOffice { get; set; }
        public int? NumberOfHotels { get; set; }
        public string? Country { get; set; }
        public List<Hotel>? Hotels { get; set; }
    }
}
