using FluentAssertions;
using System.Net.Http.Headers;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using HotelBookingPlatform.API.DTOs;
using System.Net;
using Newtonsoft.Json;
using System.Text;

namespace HotelBookingPlatform.API.IntegrationTests.IntegrationTests
{
    public class BookingControllerTests(CustomWebApplicationFactory<Program> factory) : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client = factory.CreateClient();
        private readonly ITokenService _tokenService = factory.Services.GetService<ITokenService>()!;

        [Fact]
        public async Task GetAll_ShouldReturnBookings_WhenAuthenticated()
        {
            var token = _tokenService.GenerateToken(1, "user@test.com", "User");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _client.GetAsync("/api/bookings?pageSize=10&pageNumber=1");

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var bookings = JsonConvert.DeserializeObject<IEnumerable<BookingReadDto>>(await response.Content.ReadAsStringAsync());
            bookings.Should().NotBeNull();
        }

        [Fact]
        public async Task GetAll_ShouldReturnBadRequest_WhenInputIsInvalid()
        {
            var token = _tokenService.GenerateToken(1, "user@test.com", "User");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var bokingUpdateDto = new { CheckOutDate = new DateOnly(2024, 6, 6), CheckInDate = new DateOnly(2025, 6, 7) };
            var content = new StringContent(JsonConvert.SerializeObject(bokingUpdateDto), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("/api/bookings/1", content);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetAll_ShouldReturnOk_WhenInputIsValid()
        {
            var token = _tokenService.GenerateToken(1, "user@test.com", "User");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var bokingUpdateDto = new { CheckOutDate = new DateOnly(2025, 6, 6), CheckInDate = new DateOnly(2025, 6, 5) };
            var content = new StringContent(JsonConvert.SerializeObject(bokingUpdateDto), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("/api/bookings/1", content);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
