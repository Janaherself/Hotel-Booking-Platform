using HotelBookingPlatform.Domain.DomainEntities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string email, string role);
    }
}