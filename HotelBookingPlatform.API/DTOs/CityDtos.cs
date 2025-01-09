namespace HotelBookingPlatform.API.DTOs
{
    public record CityCreateDto(string Name, string Country, string PostOffice, int NumberOfHotels);

    public record CityUpdateDto(string? Name, string? Country, string? PostOffice, int? NumberOfHotels);
    
    public record CityReadDto(int CityId, string Name, string Country, string PostOffice, 
        int NumberOfHotels, DateTime CreationDate, DateTime? ModificationDate);
}
