using FluentAssertions;
using HotelBookingPlatform.Infrastructure.Entities;
using HotelBookingPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.Infrastructure.IntegrationTests.IntegrationTests
{
    public class HotelRepositoryTests : IntegrationTestBase
    {
        private readonly HotelRepository _repository;

        public HotelRepositoryTests()
        {
            var logger = new Mock<ILogger<HotelRepository>>().Object;
            _repository = new HotelRepository(_context, logger);
        }

        [Fact]
        public async Task SearchByAmenitiesAsync_ShouldReturnHotels_WhenHotelsWithAmenitiesExist()
        {
            var city = new City { };
            var hotel = new Hotel { Amenities = "Pool", City = city };
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByAmenitiesAsync("Pool");

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task SearchByCityAsync_ShouldReturnHotels_WhenHotelsInCityExist()
        {
            var city = new City { Name = "Geeks city" };
            var hotel = new Hotel { City = city };
            _context.Cities.Add(city);
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByCityAsync("Geeks city");

            result.Should().Contain(hotel);
        }

        [Fact]
        public async Task SearchByRatingAsync_ShouldReturnHotels_WhenHotelsWithRatingExist()
        {
            var city = new City { };
            var hotel = new Hotel { Rating = 4.5f, City = city };
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            var result = await _repository.SearchByRatingAsync(4.0f);

            result.Should().Contain(hotel);
        }
    }
}
