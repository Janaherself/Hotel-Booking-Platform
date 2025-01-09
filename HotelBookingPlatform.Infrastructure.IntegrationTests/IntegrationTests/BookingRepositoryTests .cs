using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.IntegrationTests.IntegrationTests
{
    public class BookingRepositoryTests : IntegrationTestBase
    {
        private readonly BookingRepository _repository;

        public BookingRepositoryTests()
        {
            var logger = new Mock<ILogger<BookingRepository>>().Object;
            _repository = new BookingRepository(_context, logger);
        }

        [Fact]
        public async Task GetRecentlyVisitedHotelsAsync_ShouldReturnHotels_WhenBookingsExist()
        {
            var user = new User { };
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { Hotel = hotel };
            var booking = new Booking { Rooms = [room], User = user };

            _context.Users.Add(user);
            _context.Hotels.Add(hotel);
            _context.Rooms.Add(room);
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            var result = await _repository.GetRecentlyVisitedHotelsAsync(user.UserId);

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task GetTopVisitedCitiesAsync_ShouldReturnCities_WhenBookingsExist()
        {
            var city = new City { Name = "Geeks City" };

            var user = new User { };
            var user1 = new User { };
            var user2 = new User { };
            var user3 = new User { };
            var user4 = new User { };

            var hotel = new Hotel { City = city };
            var hotel1 = new Hotel { City = city };
            var hotel2 = new Hotel { City = city };
            var hotel3 = new Hotel { City = city };
            var hotel4 = new Hotel { City = city };

            var room = new Room { Hotel = hotel };
            var room1 = new Room { Hotel = hotel };
            var room2 = new Room { Hotel = hotel };
            var room3 = new Room { Hotel = hotel };
            var room4 = new Room { Hotel = hotel };

            var booking = new Booking { Rooms = [room], User = user };
            var booking1 = new Booking { Rooms = [room1], User = user1 };
            var booking2 = new Booking { Rooms = [room2], User = user2 };
            var booking3 = new Booking { Rooms = [room3], User = user3 };
            var booking4 = new Booking { Rooms = [room4], User = user4 };

            _context.Cities.Add(city);
            _context.Hotels.AddRange(hotel, hotel1, hotel2, hotel3, hotel4);
            _context.Rooms.AddRange(room, room1, room2, room3, room4);
            _context.Bookings.AddRange(booking, booking1, booking2, booking3, booking4);
            await _context.SaveChangesAsync();

            var result = await _repository.GetTopVisitedCitiesAsync();

            result.Should().Contain(city);
        }
    }
}
