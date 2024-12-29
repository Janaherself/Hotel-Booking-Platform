using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingPlatform.API.Controllers
{
    /// <summary>
    /// Handles all operations related to hotels' reviews
    /// </summary>
    /// <param name="reviewService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/reviews")]
    [ApiController]
    public class ReviewController(IService<ReviewEntity, Review> reviewService, IMapper mapper, ILogger<ReviewController> logger) : ControllerBase
    {
        /// <summary>
        /// Gets a list of all reviews in the database
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAll([FromQuery] int pageSize, [FromQuery] int pageNumber)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                logger.LogError("Page number and page size values are incorrect.");
                return BadRequest("Page number and page size must be greater than zero.");
            }

            logger.LogInformation("Calling GetAll method on the review service..");
            var reviewEntities = await reviewService.GetAllAsync(pageSize, pageNumber);

            var reviewDtos = mapper.Map<IEnumerable<ReviewReadDto>>(reviewEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(reviewDtos);
        }

        /// <summary>
        /// Deletes a review from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            logger.LogInformation("Calling delete method on the review service..");
            var isDeleted = await reviewService.Delete(id);
            if (!isDeleted)
            {
                logger.LogError("Review with id {Id} does not exist.", id);
                return NotFound($"No review with id {id} exist in the database!");
            }

            await reviewService.SaveAsync();
            logger.LogInformation("Review with id {Id} was deleted succefully.", id);

            return Ok($"Review with id {id} has been deleted successfully!");
        }
    }
}
