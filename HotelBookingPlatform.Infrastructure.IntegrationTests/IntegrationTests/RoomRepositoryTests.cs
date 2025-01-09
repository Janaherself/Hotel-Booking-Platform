using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.IntegrationTests.IntegrationTests
{
    public class RoomRepositoryTests : IntegrationTestBase
    {
        private readonly RoomRepository _repository;

        public RoomRepositoryTests()
        {
            var logger = new Mock<ILogger<RoomRepository>>().Object;
            _repository = new RoomRepository(_context, logger);
        }

        [Fact]
        public async Task SearchByAdultCapacityAsync_ShouldReturnRooms_WhenRoomsWithCapacityExist()
        {
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { AdultsCapacity = 2, Hotel = hotel };

            _context.Cities.Add(city);
            _context.Hotels.Add(hotel);
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByAdultCapacityAsync(2);

            result.Should().Contain(room);
        }

        [Fact]
        public async Task SearchByChildrenCapacityAsync_ShouldReturnRooms_WhenRoomsWithCapacityExist()
        {
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { ChildrenCapacity = 2, Hotel = hotel };

            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByChildrenCapacityAsync(2);

            result.Should().Contain(room);
        }

        [Fact]
        public async Task SearchByPriceAsync_ShouldReturnRooms_WhenRoomsWithPriceExist()
        {
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { Price = 100m, Hotel = hotel };

            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByPriceAsync(100m);

            result.Should().Contain(room);
        }

        [Fact]
        public async Task SearchByTypeAsync_ShouldReturnRooms_WhenRoomsWithTypeExist()
        {
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { Type = "Deluxe", Hotel = hotel };

            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByTypeAsync("Deluxe");

            result.Should().Contain(room);
        }

        [Fact]
        public async Task GetRoomsById_ShouldReturnRooms_WhenRoomsWithIdsExist()
        {
            var city = new City { };
            var hotel = new Hotel { City = city };
            var room = new Room { Hotel = hotel };

            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.GetRoomsById([(int)room.RoomId!]);

            result.Should().Contain(room);
        }
    }
}
