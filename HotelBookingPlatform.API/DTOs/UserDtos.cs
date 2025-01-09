namespace HotelBookingPlatform.API.DTOs
{
    public record UserReadDto(int UserId, string Email, string PasswordHash,
        string Role, DateTime CreationDate, DateTime? ModificationDate);
    
    public record UserUpdateDto(string? Role);
}
