using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace HotelBookingPlatform.Domain.Services
{
    public class TokenService(ILogger<TokenService> logger) : ITokenService
    {
        public string GenerateToken(string email, string role)
        {
            logger.LogInformation("Generating a token for user with email {Email} is in progress..", email);

            var secretKey = Environment.GetEnvironmentVariable("InnfinitySecretKey");
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity([
                    new Claim(JwtRegisteredClaimNames.Email, email),
                    new Claim("Role", role)
                ]),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = credentials,
                Issuer = Environment.GetEnvironmentVariable("InnfinityIssuer"),
                Audience = Environment.GetEnvironmentVariable("InnfinityAudience")
            };

            var handler = new JsonWebTokenHandler();

            var token = handler.CreateToken(tokenDescriptor);

            logger.LogInformation("A token was successfully created for user with email {Email}", email);

            return token;
        }
    }
}
