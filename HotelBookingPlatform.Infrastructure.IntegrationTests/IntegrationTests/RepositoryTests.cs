using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.IntegrationTests.IntegrationTests
{
    public class RepositoryTests : IntegrationTestBase
    {
        private readonly Repository<Booking> _repository;

        public RepositoryTests()
        {
            var logger = new Mock<ILogger<Repository<Booking>>>().Object;
            _repository = new Repository<Booking>(_context, logger);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnEntity_WhenEntityExists()
        {
            var user = new User { };
            var booking = new Booking { User = user };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            var result = await _repository.GetByIdAsync((int)booking.BookingId!);

            result.Should().NotBeNull();
            result!.BookingId.Should().Be(booking.BookingId);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnNull_WhenEntityDoesNotExist()
        {
            var result = await _repository.GetByIdAsync(999);

            result.Should().BeNull();
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnEntities_WhenEntitiesExist()
        {
            var bookingsCount = _context.Bookings.Count();

            var user = new User { };
            var user1 = new User { };
            var booking = new Booking { User = user };
            var booking1 = new Booking { User = user1 };

            _context.Users.AddRange(user, user1);
            _context.Bookings.AddRange(booking, booking1);
            await _context.SaveChangesAsync();

            var result = await _repository.GetAllAsync(int.MaxValue);

            result.Should().HaveCount(bookingsCount + 2);
        }

        [Fact]
        public void Add_ShouldAddEntity()
        {
            var user = new User { };
            var booking = new Booking { User = user };

            _repository.Add(booking);
            _context.SaveChanges();

            _context.Bookings.Should().Contain(booking);
        }

        [Fact]
        public void Delete_ShouldRemoveEntity()
        {
            var user = new User { };
            var booking = new Booking { User = user };

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            _repository.Delete(booking);
            _context.SaveChanges();

            _context.Bookings.Should().NotContain(booking);
        }

        [Fact]
        public void Update_ShouldUpdateEntity()
        {
            var user = new User { };
            var booking = new Booking { User = user };

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            booking.UserId = 2;
            _repository.Update(booking);
            _context.SaveChanges();

            _context.Bookings.Find(booking.BookingId)!.UserId.Should().Be(2);
        }
    }
}
