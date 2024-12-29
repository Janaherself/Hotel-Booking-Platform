namespace HotelBookingPlatform.API.DTOs
{
    public record BookingCreateDto(DateOnly CheckInDate, DateOnly CheckOutDate, decimal TotalPrice, IEnumerable<int> RoomIds);
    public record BookingUpdateDto(DateOnly? CheckInDate, DateOnly? CheckOutDate, decimal? TotalPrice, IEnumerable<int>? RoomIds);
    public record BookingReadDto(int BookingId, int UserId, DateOnly CheckInDate, DateOnly CheckOutDate,
        decimal TotalPrice, string Status, UserReadDto User, IEnumerable<RoomReadDto> Rooms);
}
