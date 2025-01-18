using HotelBookingPlatform.Domain.Exceptions;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using System.Net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace HotelBookingPlatform.API.IntegrationTests.IntegrationTests
{
    public class GlobalExceptionHandlingMiddlewareTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
    {
        [Fact]
        public async Task Middleware_ShouldReturnNotFound_WhenMiddlewareCatchesItemNotFoundException()
        {
            var mockBookingService = new Mock<IBookingService>();
            mockBookingService.Setup(s => s.DeleteAsync(It.IsAny<int>(), It.IsAny<int>())).Throws(new ItemNotFoundException());

            var client = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddSingleton(mockBookingService.Object);
                    services.AddAuthentication("TestAuth").AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("TestAuth", options => { });
                });

                builder.Configure(app =>
                {
                    app.UseAuthentication();
                    app.UseAuthorization();
                });
            }).CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Delete, "/api/bookings/1");

            var response = await client.SendAsync(request);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
