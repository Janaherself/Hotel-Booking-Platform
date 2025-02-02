﻿using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
    public class BookingController(IBookingService bookingService, IMapper mapper, ILogger<BookingController> logger) : ControllerBase
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
        public async Task<IActionResult> GetAll([FromQuery] int pageSize = 6, [FromQuery] int pageNumber = 1)
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
            var userIdClaim = User.FindFirstValue("UserId");

            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized("Invalid or missing userId claim!");
            }

            var bookingEntity = mapper.Map<BookingEntity>(bookingCreateDto);

            logger.LogInformation("Calling Add method on the booking service..");
            await bookingService.AddAsync(bookingEntity, userId);

            logger.LogInformation("Calling SaveAsync method on the booking service..");
            await bookingService.SaveAsync();

            return Ok("The booking has been added successfully!");
        }

        /// <summary>
        /// Updates a booking in the database
        /// </summary>
        /// <param name="bookingId"></param>
        /// <param name="bookingUpdateDto"></param>
        /// <returns></returns>
        [Authorize(Policy = "User")]
        [HttpPut("{bookingId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Update([FromRoute] int bookingId, [FromBody] BookingUpdateDto bookingUpdateDto)
        {
            var userIdClaim = User.FindFirstValue("UserId");

            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized("Invalid or missing userId claim!");
            }

            var bookingEntity = mapper.Map<BookingEntity>(bookingUpdateDto);
            
            logger.LogInformation("Calling the update method on the booking service..");
            var isUpdated = await bookingService.UpdateAsync(bookingId, bookingEntity, userId);

            if (!isUpdated)
            {
                return Unauthorized($"You are unauthorized to update booking with id {bookingId}!");
            }

            logger.LogInformation("Calling SaveAsync method on the booking service..");
            await bookingService.SaveAsync();

            return Ok($"Booking with ID {bookingId} has been updated successfully!");
        }

        /// <summary>
        /// Deletes a booking from the database
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        [Authorize(Policy = "User")]
        [HttpDelete("{bookingId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Delete(int bookingId)
        {
            var userIdClaim = User.FindFirstValue("UserId");

            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized("Invalid or missing userId claim!");
            }

            logger.LogInformation("Calling delete method on the booking service..");
            var isDeleted = await bookingService.DeleteAsync(bookingId, userId);
            if (!isDeleted)
            {
                return Unauthorized($"You are unauthorized to delete booking with id {bookingId}!");
            }

            logger.LogInformation("Calling SaveAsync method on the booking service..");
            await bookingService.SaveAsync();

            return Ok($"Booking with id {bookingId} has been deleted successfully!");
        }
    }
}
