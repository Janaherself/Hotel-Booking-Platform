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
    /// Handles all operations related to featured deals
    /// </summary>
    /// <param name="featuredDealsService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/featured-deals")]
    [ApiController]
    public class FeaturedDealController(
        IService<FeaturedDealEntity, FeaturedDeal> featuredDealsService, 
        IMapper mapper, 
        ILogger<FeaturedDealController> logger)
        : ControllerBase
    {
        /// <summary>
        /// Gets a list of all deals in the database
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

            logger.LogInformation("Calling GetAll method on the featured deal service..");
            var featuredDealEntities = await featuredDealsService.GetAllAsync(pageSize, pageNumber);

            var FeaturedDealDtos = mapper.Map<IEnumerable<FeaturedDealReadDto>>(featuredDealEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(FeaturedDealDtos);
        }

        /// <summary>
        /// Gets a deal by its id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            logger.LogInformation("Calling GetById method on the featured deal service..");
            var FeaturedDealEntity = await featuredDealsService.GetByIdAsync(id);
            var featuredDealDto = mapper.Map<FeaturedDealReadDto>(FeaturedDealEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(featuredDealDto);
        }

        /// <summary>
        /// Adds a new deal to the database
        /// </summary>
        /// <param name="featuredDealCreateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Add([FromBody] FeaturedDealCreateDto featuredDealCreateDto)
        {
            var featuredDealEntity = mapper.Map<FeaturedDealEntity>(featuredDealCreateDto);

            logger.LogInformation("Calling Add method on the featured deal service..");
            featuredDealsService.Add(featuredDealEntity);

            logger.LogInformation("Calling SaveAsync method on the featured deal service..");
            await featuredDealsService.SaveAsync();

            return Ok("The deal has been added successfully!");
        }

        /// <summary>
        /// Updates a deal in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="featuredDealUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] FeaturedDealUpdateDto featuredDealUpdateDto)
        {
            var featuredDealEntity = mapper.Map<FeaturedDealEntity>(featuredDealUpdateDto);

            logger.LogInformation("Calling the update method on the featured deal service..");
            var isUpdated = await featuredDealsService.Update(id, featuredDealEntity);

            if (!isUpdated)
            {
                return NotFound($"Featured deal with ID {id} does not exist!");
            }

            logger.LogInformation("Calling SaveAsync method on the featured deal service..");
            await featuredDealsService.SaveAsync();

            return Ok($"Featured deal with ID {id} has been updated successfully!");
        }

        /// <summary>
        /// Deletes a deal from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(int id)
        {
            logger.LogInformation("Calling delete method on the featured deal service..");
            var isDeleted = await featuredDealsService.Delete(id);
            if (!isDeleted)
            {
                logger.LogError("Featured deal with id {Id} does not exist.", id);
                return NotFound($"No featured deal with id {id} exist in the database!");
            }

            await featuredDealsService.SaveAsync();
            logger.LogInformation("Featured deal with id {Id} was deleted succefully.", id);

            return Ok($"Featured deal with id {id} has been deleted successfully!");
        }
    }
}
