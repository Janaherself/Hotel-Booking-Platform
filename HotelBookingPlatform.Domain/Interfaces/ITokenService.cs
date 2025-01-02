using HotelBookingPlatform.Domain.DomainEntities;

namespace HotelBookingPlatform.Domain.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(int id, string email, string role);
    }
}