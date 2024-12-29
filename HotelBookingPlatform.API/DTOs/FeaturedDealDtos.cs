namespace HotelBookingPlatform.API.DTOs
{
    public record FeaturedDealCreateDto(int HotelId, decimal OriginalPrice, decimal DiscountedPrice, DateTime StartDate, DateTime EndDate);
    public record FeaturedDealUpdateDto(int? HotelId, decimal? OriginalPrice, decimal? DiscountedPrice, DateTime? StartDate, DateTime? EndDate);
    public record FeaturedDealReadDto(int FeaturedDealId, int HotelId, decimal OriginalPrice, decimal DiscountedPrice,
        DateTime StartDate, DateTime EndDate, DateOnly CreationDate, DateOnly ModificationDate);
}
