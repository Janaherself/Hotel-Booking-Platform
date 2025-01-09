namespace HotelBookingPlatform.Domain.DomainEntities
{
    public class UserEntity
    {
        public int? UserId { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Location { get; set; }
        public string? Role { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
