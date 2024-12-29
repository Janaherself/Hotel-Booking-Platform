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
    /// Handles all operations related to bookings
    /// </summary>
    /// <param name="bookingService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/bookings")]
    [ApiController]
    public class BookingController(IService<BookingEntity, Booking> bookingService, IMapper mapper, ILogger<BookingController> logger) : ControllerBase
    {
        /// <summary>
        /// Gets a list of all bookings in the database
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

            logger.LogInformation("Calling GetAll method on the booking service..");
            var bookingEntities = await bookingService.GetAllAsync(pageSize, pageNumber);

            var bookingDtos = mapper.Map<IEnumerable<BookingReadDto>>(bookingEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(bookingDtos);
        }

        /// <summary>
        /// Gets a booking by its Id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "AdminOrUser")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            logger.LogInformation("Calling GetById method on the booking service..");
            var bookingEntity = await bookingService.GetByIdAsync(id);
            var bookingDto = mapper.Map<BookingReadDto>(bookingEntity);

            logger.LogInformation("Returning the results back to user..");
            return Ok(bookingDto);
        }

        /// <summary>
        /// Adds a new booking to the database
        /// </summary>
        /// <param name="bookingCreateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "User")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Add([FromBody] BookingCreateDto bookingCreateDto)
        {
            var bookingEntity = mapper.Map<BookingEntity>(bookingCreateDto);

            logger.LogInformation("Calling Add method on the booking service..");
            bookingService.Add(bookingEntity);

            logger.LogInformation("Calling SaveAsync method on the booking service..");
            await bookingService.SaveAsync();

            return Ok("The booking has been added successfully!");
        }

        /// <summary>
        /// Updates a booking in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookingUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "User")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] BookingUpdateDto bookingUpdateDto)
        {
            var bookingEntity = mapper.Map<BookingEntity>(bookingUpdateDto);

            logger.LogInformation("Calling the update method on the booking service..");
            var isUpdated = await bookingService.Update(id, bookingEntity);

            if (!isUpdated)
            {
                return NotFound($"Booking with ID {id} does not exist!");
            }

            logger.LogInformation("Calling SaveAsync method on the booking service..");
            await bookingService.SaveAsync();

            return Ok($"Booking with ID {id} has been updated successfully!");
        }

        /// <summary>
        /// Deletes a booking from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Policy = "User")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(int id)
        {
            logger.LogInformation("Calling delete method on the booking service..");
            var isDeleted = await bookingService.Delete(id);
            if (!isDeleted)
            {
                logger.LogError("Booking with id {Id} does not exist.", id);
                return NotFound($"No booking with id {id} exist in the database!");
            }

            await bookingService.SaveAsync();
            logger.LogInformation("Booking with id {Id} was deleted succefully.", id);

            return Ok($"Booking with id {id} has been deleted successfully!");
        }
    }
}
