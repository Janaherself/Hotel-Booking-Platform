using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.Tests.UnitTests
{
    public class UserRepositoryTests
    {
        private readonly InMemoryDbContextFactory _factory;
        private readonly AppDbContext _context;
        private readonly UserRepository _repository;

        public UserRepositoryTests()
        {
            _factory = new InMemoryDbContextFactory();
            _context = _factory.GetDbContext();
            var logger = new Mock<ILogger<UserRepository>>().Object;
            _repository = new UserRepository(_context, logger);
        }

        [Fact]
        public async Task GetByEmailAsync_ShouldReturnUser_WhenUserWithEmailExists()
        {
            var user = new User { UserId = 1, Email = "test@user1.com" };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var result = await _repository.GetByEmailAsync("test@user1.com");

            result.Should().Be(user);
        }

        [Fact]
        public async Task GetByEmailAsync_ShouldReturnNull_WhenUserWithEmailDoesNotExist()
        {
            var user = new User { UserId = 1, Email = "test@user1.com" };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var result = await _repository.GetByEmailAsync("test@user.com");

            result.Should().BeNull();
        }

        [Fact]
        public async Task RegisterAsync_ShouldReturnTrue_WhenUserIsRegistered()
        {
            var result = await _repository.RegisterAsync("test@user1.com", "hashedPassword", "User");

            result.Should().BeTrue();
            _context.Users.Should().Contain(u => u.Email == "test@user1.com");
        }
    }
}
