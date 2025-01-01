using HotelBookingPlatform.API.Middlewares;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moq;

namespace HotelBookingPlatform.API.Tests
{
    public class GlobalExceptionHandlingMiddlewareTests
    {
        [Fact]
        public async Task Middleware_ShouldReturnInternalServerError_WhenUnhandledExceptionOccurs()
        {
            var loggerMock = new Mock<ILogger<GlobalExceptionHandlingMiddleware>>();
            var middleware = new GlobalExceptionHandlingMiddleware(loggerMock.Object);

            var context = new DefaultHttpContext();
            var responseStream = new MemoryStream();
            context.Response.Body = responseStream;

            var nextDelegate = new RequestDelegate((innerContext) =>
            {
                throw new Exception("Test GlobalExceptionHandlingMiddleware");
            });

            await middleware.InvokeAsync(context, nextDelegate);

            responseStream.Seek(0, SeekOrigin.Begin);
            using var reader = new StreamReader(responseStream);

            var errorMessage = "{\"Status\":500,\"Message\":\"An internal server error occurred.\",\"Details\":\"Test GlobalExceptionHandlingMiddleware\"}";
            var responseBody = await reader.ReadToEndAsync();
            Assert.Equal(errorMessage, responseBody);
        }
    }
}
