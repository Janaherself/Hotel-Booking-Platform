namespace HotelBookingPlatform.API.DTOs
{
    public record HotelCreateDto(string Name, int CityId, float Rating, string Owner, string Location);
    public record HotelUpdateDto(string? Name, int? CityId, string? Owner, string? Location);
    public record HotelReadDto(int HotelId, string Name, int CityId, float Rating, string Owner, 
        string Location, DateOnly CreationDate, DateOnly ModificationDate);
}
