using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.IntegrationTests.IntegrationTests
{
    public class UserRepositoryTests : IntegrationTestBase
    {
        private readonly UserRepository _repository;

        public UserRepositoryTests()
        {
            var logger = new Mock<ILogger<UserRepository>>().Object;
            _repository = new UserRepository(_context, logger);
        }

        [Fact]
        public async Task GetByEmailAsync_ShouldReturnUser_WhenUserWithEmailExists()
        {
            var user = new User { Email = "test@user.com" };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var result = await _repository.GetByEmailAsync("test@user.com");

            result.Should().Be(user);
        }

        [Fact]
        public async Task GetByEmailAsync_ShouldReturnNull_WhenUserWithEmailDoesNotExist()
        {
            var user = new User { Email = "test@user.com" };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var result = await _repository.GetByEmailAsync("test@user1.com");

            result.Should().Be(null);
        }

        [Fact]
        public async Task RegisterAsync_ShouldReturnTrue_WhenUserIsRegistered()
        {
            var result = await _repository.RegisterAsync("test@user.com", "hashedPassword", "User");

            result.Should().BeTrue();
            _context.Users.Should().Contain(u => u.Email == "test@user.com");
        }
    }
}
