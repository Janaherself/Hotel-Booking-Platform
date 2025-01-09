namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class CityEntity
    {
        public int? CityId { get; set; }
        public string? Name { get; set; }
        public string? PostOffice { get; set; }
        public int? NumberOfHotels { get; set; }
        public string? Country { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
