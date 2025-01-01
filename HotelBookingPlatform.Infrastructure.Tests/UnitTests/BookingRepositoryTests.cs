using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.Tests.UnitTests
{
    public class BookingRepositoryTests
    {
        private readonly InMemoryDbContextFactory _factory;
        private readonly AppDbContext _context;
        private readonly BookingRepository _repository;

        public BookingRepositoryTests()
        {
            _factory = new InMemoryDbContextFactory();
            _context = _factory.GetDbContext();
            var logger = new Mock<ILogger<BookingRepository>>().Object;
            _repository = new BookingRepository(_context, logger);
        }

        [Fact]
        public async Task GetRecentlyVisitedHotelsAsync_ShouldReturnHotels_WhenBookingsExist()
        {
            var user = new User { };
            var hotel = new Hotel { };
            var room = new Room { Hotel = hotel };
            var booking = new Booking {  User = user, Rooms = [room] };

            _context.Users.Add(user);
            _context.Hotels.Add(hotel);
            _context.Rooms.Add(room);
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            var result = await _repository.GetRecentlyVisitedHotelsAsync(user.UserId);

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task GetRecentlyVisitedHotelsAsync_ShouldReturnEmptyIEnumerable_WhenNoBookingsExist()
        {
            var user = new User { };

            var result = await _repository.GetRecentlyVisitedHotelsAsync(user.UserId);

            result.Should().BeEmpty();
        }

        [Fact]
        public async Task GetTopVisitedCitiesAsync_ShouldReturnCities_WhenBookingsExist()
        {
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { Hotel = hotel };
            var booking = new Booking { Rooms = [room] };

            _context.Cities.Add(city);
            _context.Hotels.Add(hotel);
            _context.Rooms.Add(room);
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            var result = await _repository.GetTopVisitedCitiesAsync();

            result.Should().Contain(city);
        }

        [Fact]
        public async Task GetTopVisitedCitiesAsync_ShouldReturnEmptyIEnumerable_WhenNoBookingsExist()
        {
            var result = await _repository.GetTopVisitedCitiesAsync();

            result.Should().BeEmpty();
        }
    }
}
