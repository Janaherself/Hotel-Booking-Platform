using FluentAssertions;
using HotelBookingPlatform.Domain.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Domain.Tests.UnitTests
{
    public class TokenServiceTests
    {
        private readonly Mock<ILogger<TokenService>> _mockLogger;
        private readonly TokenService _tokenService;

        public TokenServiceTests()
        {
            _mockLogger = new Mock<ILogger<TokenService>>();
            _tokenService = new TokenService(_mockLogger.Object);
        }

        [Fact]
        public void GenerateToken_ShouldGenerateToken_WhenCalledWithValidParameters()
        {
            var id = 1;
            var email = "user@example.com";
            var role = "User";

            Environment.SetEnvironmentVariable("InnfinitySecretKey", "mySuperDuperSecretKeyMock123456789123456789");
            Environment.SetEnvironmentVariable("InnfinityIssuer", "myIssuer");
            Environment.SetEnvironmentVariable("InnfinityAudience", "myAudience");

            var token = _tokenService.GenerateToken(id, email, role);

            token.Should().NotBeNull();
        }

        [Fact]
        public void GenerateToken_ShouldThrowException_WhenSecretKeyIsMissing()
        {
            var id = 1;
            var email = "user@example.com";
            var role = "User";

            Environment.SetEnvironmentVariable("InnfinitySecretKey", null);

            Action act = () => _tokenService.GenerateToken(id, email, role);

            act.Should().Throw<ArgumentNullException>();
        }
    }
}
