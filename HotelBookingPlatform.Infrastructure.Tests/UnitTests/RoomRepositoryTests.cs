using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.Tests.UnitTests
{
    public class RoomRepositoryTests
    {
        private readonly InMemoryDbContextFactory _factory;
        private readonly AppDbContext _context;
        private readonly RoomRepository _repository;

        public RoomRepositoryTests()
        {
            _factory = new InMemoryDbContextFactory();
            _context = _factory.GetDbContext();
            var logger = new Mock<ILogger<RoomRepository>>().Object;
            _repository = new RoomRepository(_context, logger);
        }

        [Fact]
        public async Task SearchByAdultCapacityAsync_ShouldReturnRooms_WhenRoomsWithCapacityExist()
        {
            var room = new Room { AdultsCapacity = 2 };
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByAdultCapacityAsync(2);

            result.Should().Contain(room);
        }

        [Fact]
        public async Task SearchByChildrenCapacityAsync_ShouldReturnRooms_WhenRoomsWithCapacityExist()
        {
            var room = new Room { ChildrenCapacity = 2 };
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByChildrenCapacityAsync(2);

            result.Should().Contain(room);
        }

        [Fact]
        public async Task SearchByChildrenCapacityAsync_ShouldNotReturnRooms_WhenRoomsDoesNotMatchChildrenCapacity()
        {
            var room = new Room { ChildrenCapacity = 2 };
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByChildrenCapacityAsync(3);

            result.Should().NotContain(room);
        }

        [Fact]
        public async Task SearchByPriceAsync_ShouldReturnRooms_WhenRoomsWithPriceExist()
        {
            var room = new Room { Price = 100m };
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByPriceAsync(100m);

            result.Should().Contain(room);
        }

        [Fact]
        public async Task SearchByTypeAsync_ShouldReturnRooms_WhenRoomsWithTypeExist()
        {
            var room = new Room { Type = "Super Deluxe" };
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByTypeAsync("Deluxe");

            result.Should().Contain(room);
        }

        [Fact]
        public async Task GetRoomsById_ShouldReturnRooms_WhenRoomsWithIdsExist()
        {
            var room1 = new Room { RoomId = 1 };
            var room2 = new Room { RoomId = 2 };

            _context.Rooms.AddRange(room1, room2);
            await _context.SaveChangesAsync();

            var result = await _repository.GetRoomsById([1, 2]);

            result.Should().Contain(room1);
            result.Should().Contain(room2);
        }

        [Fact]
        public async Task GetRoomsById_ShouldNotReturnRooms_WhenRoomsWithIdsDoesNotExist()
        {
            var room1 = new Room { RoomId = 1 };
            var room2 = new Room { RoomId = 2 };

            _context.Rooms.AddRange(room1, room2);
            await _context.SaveChangesAsync();

            var result = await _repository.GetRoomsById([3, 4]);

            result.Should().BeEmpty();
        }
    }
}
