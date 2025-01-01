using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.Tests.UnitTests
{
    public class RepositoryTests
    {
        private readonly InMemoryDbContextFactory _factory;
        private readonly AppDbContext _context;
        private readonly Repository<Booking> _repository;

        public RepositoryTests()
        {
            _factory = new InMemoryDbContextFactory();
            _context = _factory.GetDbContext();
            var logger = new Mock<ILogger<Repository<Booking>>>().Object;
            _repository = new Repository<Booking>(_context, logger);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnEntity_WhenEntityExists()
        {
            var booking = new Booking { };
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            var result = await _repository.GetByIdAsync(1);

            result.Should().NotBeNull();
            result!.BookingId.Should().Be(1);
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
            _context.Bookings.AddRange(new Booking { }, new Booking { });
            await _context.SaveChangesAsync();

            var result = await _repository.GetAllAsync();

            result.Should().HaveCount(2);
        }

        [Fact]
        public void Add_ShouldAddEntity()
        {
            var booking = new Booking { };

            _repository.Add(booking);
            _context.SaveChanges();

            _context.Bookings.Should().Contain(booking);
        }

        [Fact]
        public void Delete_ShouldRemoveEntity()
        {
            var booking = new Booking { };
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            _repository.Delete(booking);
            _context.SaveChanges();

            _context.Bookings.Should().NotContain(booking);
        }

        [Fact]
        public void Update_ShouldUpdateEntity()
        {
            var booking = new Booking { BookingId = 1 };
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            booking.UserId = 2;
            _repository.Update(booking);
            _context.SaveChanges();

            _context.Bookings.First().UserId.Should().Be(2);
        }
    }
}
