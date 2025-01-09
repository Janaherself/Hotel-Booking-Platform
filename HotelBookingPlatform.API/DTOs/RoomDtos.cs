namespace HotelBookingPlatform.API.DTOs
{
    public record RoomCreateDto(int HotelId, string Number, bool IsAvailable, decimal Price, int AdultsCapacity, int ChildrenCapacity);
    
    public record RoomUpdateDto(string? Number, bool? IsAvailable, decimal? Price, int? AdultsCapacity, int? ChildrenCapacity);
    
    public record RoomReadDto(int RoomId, int HotelId, string Number, bool IsAvailable, decimal Price, 
        int AdultsCapacity, int ChildrenCapacity, DateTime CreationDate, DateTime? ModificationDate);
}
