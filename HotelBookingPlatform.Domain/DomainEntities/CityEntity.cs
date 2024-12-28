namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class CityEntity
    {
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PostOffice { get; set; } = string.Empty;
        public int NumberOfHotels { get; set; }
        public string Country { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
