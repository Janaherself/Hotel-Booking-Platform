using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingPlatform.API.Controllers
{
    /// <summary>
    /// Handles special statistics in the system
    /// </summary>
    /// <param name="bookingService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api")]
    [ApiController]
    public class SpecialsController(IBookingService bookingService, IMapper mapper, ILogger<BookingController> logger) : ControllerBase
    {

        /// <summary>
        /// Gets the latest 5 hotels that the user visited
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("recent-visited-hotels/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetRecentlyVisitedHotelsAsync(int userId)
        {
            logger.LogInformation("Calling the method on the booking service..");
            var hotelEntities = await bookingService.GetRecentlyVisitedHotelsAsync(userId);

            if (!hotelEntities.Any())
            {
                logger.LogError("User with id {Id} did not visit any hotels yet.", userId);
                return NotFound($"User with id {userId} did not visit any hotels yet.");
            }

            var hotelDtos = mapper.Map<HotelReadDto>(hotelEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(hotelDtos);
        }

        /// <summary>
        /// Gets the top 5 cities visited in the system
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("top-visited-cities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetTopVisitedCitiesAsync()
        {
            logger.LogInformation("Calling the method on the booking service..");
            var cityEntities = await bookingService.GetTopVisitedCitiesAsync();

            var cityDtos = mapper.Map<CityReadDto>(cityEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(cityDtos);
        }
    }
}
