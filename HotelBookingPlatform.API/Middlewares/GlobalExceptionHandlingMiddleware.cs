using System.Text.Json;

namespace HotelBookingPlatform.API.Middlewares
{
    public class GlobalExceptionHandlingMiddleware(ILogger<GlobalExceptionHandlingMiddleware> logger) : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                logger.LogError(e, "{Message}", e.Message);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                var errorResponse = new
                {
                    Status = context.Response.StatusCode,
                    Message = "An internal server error occurred.",
                    Details = e.Message
                };

                var jsonErrorResponse = JsonSerializer.Serialize(errorResponse);

                await context.Response.WriteAsync(jsonErrorResponse);
            }
        }
    }
}
