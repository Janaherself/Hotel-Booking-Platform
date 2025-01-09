using FluentAssertions;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace HotelBookingPlatform.API.IntegrationTests.IntegrationTests
{
    public class AuthenticationControllerTests(CustomWebApplicationFactory<Program> factory) : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client = factory.CreateClient();

        [Fact]
        public async Task Register_ShouldReturnToken_WhenCredentialsAreValid()
        {
            var loginDto = new
            {
                Email = "test@test.com",
                Password = "Test1234!"
            };
            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/authentication/register", content);

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var token = await response.Content.ReadAsStringAsync();
            token.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public async Task Register_ShouldReturnBadRequest_WhenCredentialsAreInvalid()
        {
            var loginDto = new
            {
                Email = "testtest.com",
                Password = "1234"
            };
            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/authentication/register", content);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Login_ShouldReturnNotFound_WhenUserIsNotRegistered()
        {
            var loginDto = new
            {
                Email = "user@test.com",
                Password = "Test1234!"
            };
            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/authentication/login", content);

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Login_ShouldReturnBadRequest_WhenCredentialsAreInvalid()
        {
            var loginDto = new
            {
                Email = "testtest.com",
                Password = "1234"
            };
            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/authentication/login", content);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
