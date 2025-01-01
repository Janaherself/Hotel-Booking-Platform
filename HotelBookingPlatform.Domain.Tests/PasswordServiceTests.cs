using Moq;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using FluentAssertions;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using HotelBookingPlatform.Domain.Services;

namespace HotelBookingPlatform.Domain.Tests.UnitTests
{
    public class PasswordServiceTests
    {
        private readonly Mock<ILogger<PasswordService>> _mockLogger;
        private readonly PasswordService _passwordService;

        public PasswordServiceTests()
        {
            _mockLogger = new Mock<ILogger<PasswordService>>();
            _passwordService = new PasswordService(_mockLogger.Object);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnTrue_WhenPasswordIsCorrect()
        {
            var enteredPassword = "correctPassword";
            var storedPasswordHash = _passwordService.HashPassword(enteredPassword);

            var result = _passwordService.VerifyPassword(enteredPassword, storedPasswordHash);

            result.Should().BeTrue();
        }

        [Fact]
        public void VerifyPassword_ShouldReturnFalse_WhenPasswordIsIncorrect()
        {
            var wrongPassword = "wrongPassword";
            var correctPassword = "correctPassword";

            var storedPasswordHash = _passwordService.HashPassword(correctPassword);

            var result = _passwordService.VerifyPassword(wrongPassword, storedPasswordHash);

            result.Should().BeFalse();
        }

        [Fact]
        public void VerifyPassword_ShouldThrowFormatException_WhenStoredPasswordHashIsInvalid()
        {
            var enteredPassword = "password";
            var invalidStoredPasswordHash = "invalidHash";

            Action act = () => _passwordService.VerifyPassword(enteredPassword, invalidStoredPasswordHash);

            act.Should().Throw<FormatException>().WithMessage("Stored password hash is in an invalid format.");
        }

        [Fact]
        public void HashPassword_ShouldReturnValidHash_WhenCalledWithPassword()
        {
            var password = "password123";

            var result = _passwordService.HashPassword(password);

            result.Should().NotBeNullOrEmpty();
            result.Split(':').Length.Should().Be(2);
        }

        [Fact]
        public void HashPassword_ShouldGenerateDifferentHashes_WhenCalledMultipleTimes()
        {
            var password = "password123";

            var hash1 = _passwordService.HashPassword(password);
            var hash2 = _passwordService.HashPassword(password);

            hash1.Should().NotBe(hash2);
        }

        [Fact]
        public void VerifyPassword_ShouldThrowException_WhenSaltOrHashIsCorrupted()
        {
            var enteredPassword = "password";
            var corruptedStoredPasswordHash = "corrupted:salt:hash";

            Action act = () => _passwordService.VerifyPassword(enteredPassword, corruptedStoredPasswordHash);

            act.Should().Throw<FormatException>().WithMessage("Stored password hash is in an invalid format.");
        }
    }
}
