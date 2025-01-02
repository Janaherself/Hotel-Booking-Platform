using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;

namespace HotelBookingPlatform.Domain.Services
{
    public class PasswordService(ILogger<PasswordService> logger) : IPasswordService
    {
        public bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            var parts = storedPasswordHash.Split(':');
            if (parts.Length != 2)
            {
                throw new FormatException("Stored password hash is in an invalid format.");
            }

            logger.LogInformation("Hashing entered password..");

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedHash = Convert.FromBase64String(parts[1]);

            byte[] enteredHash = KeyDerivation.Pbkdf2(
                password: enteredPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100_000,
                numBytesRequested: 64);

            logger.LogInformation("Verifying password..");

            return CryptographicOperations.FixedTimeEquals(storedHash, enteredHash);
        }

        public string HashPassword(string password)
        {
            logger.LogInformation("Hashing password..");
            byte[] salt = RandomNumberGenerator.GetBytes(64);

            byte[] hash = KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100_000,
                numBytesRequested: 64);

            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }
    }
}
