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
    /// Handles all operations related to rooms
    /// </summary>
    /// <param name="roomService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/rooms")]
    [ApiController]
    public class RoomController(IRoomService roomService, IMapper mapper, ILogger<RoomController> logger) : ControllerBase
    {
        /// <summary>
        /// Gets a list of all rooms in the database
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

            logger.LogInformation("Calling GetAll method on the room service..");
            var roomEntities = await roomService.GetAllAsync(pageSize, pageNumber);

            var roomDtos = mapper.Map<IEnumerable<RoomReadDto>>(roomEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(roomDtos);
        }

        /// <summary>
        /// Gets a room by its Id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            logger.LogInformation("Calling GetById method on the room service..");
            var roomEntity = await roomService.GetByIdAsync(id);
            var roomDto = mapper.Map<RoomReadDto>(roomEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(roomDto);
        }

        /// <summary>
        /// Adds a new room to the database
        /// </summary>
        /// <param name="roomCreateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Add([FromBody] RoomCreateDto roomCreateDto)
        {
            var roomEntity = mapper.Map<RoomEntity>(roomCreateDto);

            logger.LogInformation("Calling Add method on the room service..");
            roomService.Add(roomEntity);

            logger.LogInformation("Calling SaveAsync method on the room service..");
            await roomService.SaveAsync();

            return Ok("The room has been added successfully!");
        }

        /// <summary>
        /// Updates a room in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roomUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] RoomUpdateDto roomUpdateDto)
        {
            var roomEntity = mapper.Map<RoomEntity>(roomUpdateDto);

            logger.LogInformation("Calling the update method on the room service..");
            var isUpdated = await roomService.UpdateAsync(id, roomEntity);

            if (!isUpdated)
            {
                return NotFound($"Room with ID {id} does not exist!");
            }

            logger.LogInformation("Calling SaveAsync method on the room service..");
            await roomService.SaveAsync();

            return Ok($"Room with ID {id} has been updated successfully!");
        }

        /// <summary>
        /// Deletes a room from the database
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
            logger.LogInformation("Calling delete method on the room service..");
            var isDeleted = await roomService.DeleteAsync(id);
            if (!isDeleted)
            {
                logger.LogError("Room with id {Id} does not exist.", id);
                return NotFound($"No room with id {id} exist in the database!");
            }

            await roomService.SaveAsync();
            logger.LogInformation("Room with id {Id} was deleted succefully.", id);

            return Ok($"Room with id {id} has been deleted successfully!");
        }
    }
}
