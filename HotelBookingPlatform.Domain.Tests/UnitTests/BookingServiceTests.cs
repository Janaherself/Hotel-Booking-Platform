using AutoMapper;
using FluentAssertions;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Exceptions;
using HotelBookingPlatform.Domain.Services;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Domain.Tests.UnitTests
{
    public class BookingServiceTests
    {
        private readonly Mock<IBookingRepository> _bookingRepositoryMock;
        private readonly Mock<IRoomRepository> _roomRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ILogger<BookingService>> _loggerMock;
        private readonly BookingService _bookingService;

        public BookingServiceTests()
        {
            _bookingRepositoryMock = new Mock<IBookingRepository>();
            _roomRepositoryMock = new Mock<IRoomRepository>();
            _mapperMock = new Mock<IMapper>();
            _loggerMock = new Mock<ILogger<BookingService>>();
            _bookingService = new BookingService(_bookingRepositoryMock.Object, _roomRepositoryMock.Object, _mapperMock.Object, _loggerMock.Object);
        }

        [Fact]
        public async Task GetRecentlyVisitedHotelsAsync_ShouldReturnMappedHotels()
        {
            var userId = 1;
            var hotels = new List<Hotel> { new() };
            var hotelEntities = new List<HotelEntity> { new() };

            _bookingRepositoryMock.Setup(repo => repo.GetRecentlyVisitedHotelsAsync(userId)).ReturnsAsync(hotels);
            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<HotelEntity>>(hotels)).Returns(hotelEntities);

            var result = await _bookingService.GetRecentlyVisitedHotelsAsync(userId);

            result.Should().BeEquivalentTo(hotelEntities);
        }

        [Fact]
        public async Task GetTopVisitedCitiesAsync_ShouldReturnMappedCities()
        {
            // Arrange
            var cities = new List<City> { new() };
            var cityEntities = new List<CityEntity> { new() };

            _bookingRepositoryMock.Setup(repo => repo.GetTopVisitedCitiesAsync()).ReturnsAsync(cities);
            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<CityEntity>>(cities)).Returns(cityEntities);

            // Act
            var result = await _bookingService.GetTopVisitedCitiesAsync();

            // Assert
            result.Should().BeEquivalentTo(cityEntities);
        }

        [Fact]
        public async Task Add_ShouldCallBaseAdd_WhenRoomIdsAreValid()
        {
            var bookingEntity = new BookingEntity { RoomIds = [1, 2] };
            var userId = 1;
            var rooms = new List<Room> { new(), new() };
            var roomEntities = new List<RoomEntity> { new(), new() };

            _roomRepositoryMock.Setup(repo => repo.GetRoomsById(bookingEntity.RoomIds)).ReturnsAsync(rooms);
            _mapperMock.Setup(mapper => mapper.Map<List<RoomEntity>>(rooms)).Returns(roomEntities);

            await _bookingService.AddAsync(bookingEntity, userId);

            bookingEntity.Rooms.Should().BeEquivalentTo(roomEntities);
            bookingEntity.UserId.Should().Be(userId);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnFalse_WhenUserIdDoesNotMatch()
        {
            var bookingId = 1;
            var bookingEntity = new BookingEntity();
            var userId = 1;
            var booking = new Booking { UserId = 2 };

            _bookingRepositoryMock.Setup(repo => repo.GetByIdAsync(bookingId)).ReturnsAsync(booking);

            var result = await _bookingService.UpdateAsync(bookingId, bookingEntity, userId);

            result.Should().BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_ShouldThrowInvalidRoomIdException_WhenRoomIdsAreInvalid()
        {
            var bookingId = 1;
            var bookingEntity = new BookingEntity { RoomIds = [1, 2] };
            var userId = 1;
            var booking = new Booking { UserId = userId };

            _bookingRepositoryMock.Setup(repo => repo.GetByIdAsync(bookingId)).ReturnsAsync(booking);
            _roomRepositoryMock.Setup(repo => repo.GetRoomsById(bookingEntity.RoomIds)).ReturnsAsync([]);

            var act = async () => await _bookingService.UpdateAsync(bookingId, bookingEntity, userId);

            await act.Should().ThrowAsync<InvalidRoomIdException>();
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnTrue_WhenUpdateIsSuccessful()
        {
            var bookingId = 1;
            var bookingEntity = new BookingEntity { RoomIds = [1, 2] };
            var userId = 1;
            var booking = new Booking { UserId = userId };
            var rooms = new List<Room> { new(), new() };

            _bookingRepositoryMock.Setup(repo => repo.GetByIdAsync(bookingId)).ReturnsAsync(booking);
            _roomRepositoryMock.Setup(repo => repo.GetRoomsById(bookingEntity.RoomIds)).ReturnsAsync(rooms);

            var result = await _bookingService.UpdateAsync(bookingId, bookingEntity, userId);

            result.Should().BeTrue();
        }
    }
}