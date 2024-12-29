namespace HotelBookingPlatform.API.DTOs
{
    public record ReviewReadDto(int ReviewId, int UserId, int HotelId, string ReviewText, bool IsConfirmedBooking);
}
