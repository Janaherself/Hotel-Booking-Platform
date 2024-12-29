namespace HotelBookingPlatform.API.DTOs
{
    public record UserReadDto(int UserId, string Email, string PasswordHash, string Role);
    public record UserUpdateDto(string? Role);
}
