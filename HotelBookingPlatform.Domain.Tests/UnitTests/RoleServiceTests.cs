using HotelBookingPlatform.Domain.Services;
using Microsoft.Extensions.Logging;
using Moq;
using FluentAssertions;

namespace HotelBookingPlatform.Domain.Tests.UnitTests
{
    public class RoleServiceTests
    {
        private readonly Mock<ILogger<RoleService>> _mockLogger;
        private readonly RoleService _roleService;

        public RoleServiceTests()
        {
            _mockLogger = new Mock<ILogger<RoleService>>();
            _roleService = new RoleService(_mockLogger.Object);
        }

        [Fact]
        public void AssignRole_ShouldAssignAdminRole_WhenEmailIsAdmin()
        {
            var adminEmail = "admin@admin.com";

            var result = _roleService.AssignRole(adminEmail);

            result.Should().Be("Admin");
        }

        [Fact]
        public void AssignRole_ShouldAssignUserRole_WhenEmailIsNotAdmin()
        {
            var userEmail = "not@admin.com";

            var result = _roleService.AssignRole(userEmail);

            result.Should().Be("User");
        }
    }
}
