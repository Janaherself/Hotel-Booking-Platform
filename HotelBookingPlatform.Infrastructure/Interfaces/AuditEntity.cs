namespace HotelBookingPlatform.Infrastructure.Interfaces
{
    public abstract class AuditEntity
    {
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public DateTime? ModificationDate { get; set; }
    }
}
