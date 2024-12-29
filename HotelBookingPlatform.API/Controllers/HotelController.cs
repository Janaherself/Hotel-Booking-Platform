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
    /// Handles all operations related to hotels
    /// </summary>
    /// <param name="hotelService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/hotels")]
    [ApiController]
    public class HotelController(IService<HotelEntity, Hotel> hotelService, IMapper mapper, ILogger<HotelController> logger) : ControllerBase
    {
        /// <summary>
        /// Gets a list of all hotels in the database
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

            logger.LogInformation("Calling GetAll method on the hotel service..");
            var hotelEntities = await hotelService.GetAllAsync(pageSize, pageNumber);

            var hotelDtos = mapper.Map<IEnumerable<HotelReadDto>>(hotelEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(hotelDtos);
        }

        /// <summary>
        /// Gets a hotel by its Id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            logger.LogInformation("Calling GetById method on the hotel service..");
            var hotelEntity = await hotelService.GetByIdAsync(id);
            var hotelDto = mapper.Map<HotelReadDto>(hotelEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(hotelDto);
        }

        /// <summary>
        /// Adds a new hotel to the database
        /// </summary>
        /// <param name="hotelCreateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Add([FromBody] HotelCreateDto hotelCreateDto)
        {
            var hotelEntity = mapper.Map<HotelEntity>(hotelCreateDto);

            logger.LogInformation("Calling Add method on the hotel service..");
            hotelService.Add(hotelEntity);

            logger.LogInformation("Calling SaveAsync method on the hotel service..");
            await hotelService.SaveAsync();

            return Ok("The hotel has been added successfully!");
        }

        /// <summary>
        /// Updates a hotel in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hotelUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] HotelUpdateDto hotelUpdateDto)
        {
            var hotelEntity = mapper.Map<HotelEntity>(hotelUpdateDto);

            logger.LogInformation("Calling the update method on the hotel service..");
            var isUpdated = await hotelService.UpdateAsync(id, hotelEntity);

            if (!isUpdated)
            {
                return NotFound($"Hotel with ID {id} does not exist!");
            }

            logger.LogInformation("Calling SaveAsync method on the hotel service..");
            await hotelService.SaveAsync();

            return Ok($"Hotel with ID {id} has been updated successfully!");
        }

        /// <summary>
        /// Deletes a hotel from the database
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
            logger.LogInformation("Calling delete method on the hotel service..");
            var isDeleted = await hotelService.DeleteAsync(id);
            if (!isDeleted)
            {
                logger.LogError("Hotel with id {Id} does not exist.", id);
                return NotFound($"No hotel with id {id} exist in the database!");
            }

            await hotelService.SaveAsync();
            logger.LogInformation("Hotel with id {Id} was deleted succefully.", id);

            return Ok($"Hotel with id {id} has been deleted successfully!");
        }
    }
}
