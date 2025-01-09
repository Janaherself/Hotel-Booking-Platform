using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingPlatform.API.Controllers
{
    /// <summary>
    /// Handles all operations related to users
    /// </summary>
    /// <param name="userService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/users")]
    [ApiController]
    public class UserController(IUserService userService, IMapper mapper, ILogger<UserController> logger) : ControllerBase
    {
        /// <summary>
        /// Gets a list of all users in the database
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

            logger.LogInformation("Calling GetAll method on the user service..");
            var userEntities = await userService.GetAllAsync(pageSize, pageNumber);

            var userDtos = mapper.Map<IEnumerable<UserReadDto>>(userEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(userDtos);
        }

        /// <summary>
        /// Gets a user by its id from the database 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            logger.LogInformation("Calling GetById method on the user service..");
            var userEntity = await userService.GetByIdAsync(id);
            var userDto = mapper.Map<UserReadDto>(userEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(userDto);
        }

        /// <summary>
        /// Gets a user by its email from the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("by-email")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetByEmail([FromQuery] string email)
        {
            logger.LogInformation("Calling GetByEmail method on the user service..");
            var userEntity = await userService.GetByEmailAsync(email);
            var userDto = mapper.Map<UserReadDto>(userEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(userDto);
        }

        /// <summary>
        /// Updates a user in the database 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UserUpdateDto userUpdateDto)
        {
            var userEntity = mapper.Map<UserEntity>(userUpdateDto);

            logger.LogInformation("Calling the update method on the user service..");
            var isUpdated = await userService.UpdateAsync(id, userEntity);

            if (!isUpdated)
            {
                return NotFound($"User with ID {id} does not exist!");
            }

            logger.LogInformation("Calling SaveAsync method on the user service..");
            await userService.SaveAsync();

            return Ok($"User with ID {id} has been updated successfully!");
        }
    }
}
