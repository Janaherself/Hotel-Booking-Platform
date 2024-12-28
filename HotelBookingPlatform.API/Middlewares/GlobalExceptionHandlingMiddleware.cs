using HotelBookingPlatform.Domain.Exceptions;
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

                if (e is ItemNotFoundException)
                {
                    context.Response.StatusCode = StatusCodes.Status404NotFound;

                    var notFoundResponse = new
                    {
                        Status = context.Response.StatusCode,
                        e.Message
                    };

                    await context.Response.WriteAsync(JsonSerializer.Serialize(notFoundResponse));
                }

                else
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                    var errorResponse = new
                    {
                        Status = context.Response.StatusCode,
                        Message = "An internal server error occurred.",
                        Details = e.Message
                    };

                    await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
                }
            }
        }
    }
}
