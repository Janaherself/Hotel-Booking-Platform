using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.Tests.UnitTests
{
    public class HotelRepositoryTests
    {
        private readonly InMemoryDbContextFactory _factory;
        private readonly AppDbContext _context;
        private readonly HotelRepository _repository;

        public HotelRepositoryTests()
        {
            _factory = new InMemoryDbContextFactory();
            _context = _factory.GetDbContext();
            var logger = new Mock<ILogger<HotelRepository>>().Object;
            _repository = new HotelRepository(_context, logger);
        }

        [Fact]
        public async Task SearchByAmenitiesAsync_ShouldReturnHotels_WhenHotelsWithAmenitiesExist()
        {
            var hotel = new Hotel { Amenities = "Pool" };
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByAmenitiesAsync("Pool");

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task SearchByCityAsync_ShouldReturnHotels_WhenHotelsInCityExist()
        {
            var city = new City {  Name = "Geeks city" };
            var hotel = new Hotel { City = city };
            _context.Cities.Add(city);
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByCityAsync("Geeks");

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task SearchByRatingAsync_ShouldReturnHotels_WhenHotelsWithRatingExist()
        {
            var hotel = new Hotel { Rating = 4.5f };

            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByRatingAsync(4.0f);

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task SearchByRatingAsync_ShouldNotReturnRooms_WhenNoHotelsMatchRating()
        {
            var hotel1 = new Hotel { Rating = 3.9f };

            _context.Hotels.Add(hotel1);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByRatingAsync(4.0f);

            result.Should().NotContain(hotel1);
        }
    }
}
