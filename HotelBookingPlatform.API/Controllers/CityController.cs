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
    /// Handles all operations related to cities
    /// </summary>
    /// <param name="cityService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/cities")]
    [ApiController]
    public class CityController(IService<CityEntity, City> cityService, IMapper mapper, ILogger<CityController> logger) : ControllerBase
    {
        /// <summary>
        /// Gets a list of all cities in the database
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAll([FromQuery] int pageSize = 6, [FromQuery] int pageNumber = 1)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                logger.LogError("Page number and page size values are incorrect.");
                return BadRequest("Page number and page size must be greater than zero.");
            }

            logger.LogInformation("Calling GetAll method on the city service..");
            var cityEntities = await cityService.GetAllAsync(pageSize, pageNumber);

            var cityDtos = mapper.Map<IEnumerable<CityReadDto>>(cityEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(cityDtos);
        }

        /// <summary>
        /// Gets a city by its Id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            logger.LogInformation("Calling GetById method on the city service..");
            var cityEntity = await cityService.GetByIdAsync(id);
            var cityDto = mapper.Map<CityReadDto>(cityEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(cityDto);
        }

        /// <summary>
        /// Adds a new city to the database
        /// </summary>
        /// <param name="cityCreateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Add([FromBody] CityCreateDto cityCreateDto)
        {
            var cityEntity = mapper.Map<CityEntity>(cityCreateDto);

            logger.LogInformation("Calling Add method on the city service..");
            cityService.Add(cityEntity);

            logger.LogInformation("Calling SaveAsync method on the city service..");
            await cityService.SaveAsync();

            return Ok("The city has been added successfully!");
        }

        /// <summary>
        /// Updates a city in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cityUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CityUpdateDto cityUpdateDto)
        {
            var cityEntity = mapper.Map<CityEntity>(cityUpdateDto);

            logger.LogInformation("Calling the update method on the city service..");
            var isUpdated = await cityService.UpdateAsync(id, cityEntity);

            if (!isUpdated)
            {
                return NotFound($"City with ID {id} does not exist!");
            }

            logger.LogInformation("Calling SaveAsync method on the city service..");
            await cityService.SaveAsync();

            return Ok($"City with ID {id} has been updated successfully!");
        }

        /// <summary>
        /// Deletes a city from the database
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
            logger.LogInformation("Calling delete method on the city service..");
            var isDeleted = await cityService.DeleteAsync(id);
            if (!isDeleted)
            {
                logger.LogError("City with id {Id} does not exist.", id);
                return NotFound($"No city with id {id} exist in the database!");
            }

            await cityService.SaveAsync();
            logger.LogInformation("City with id {Id} was deleted succefully.", id);

            return Ok($"City with id {id} has been deleted successfully!");
        }
    }
}
