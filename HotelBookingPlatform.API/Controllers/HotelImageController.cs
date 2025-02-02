﻿using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using HotelBookingPlatform.Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingPlatform.API.Controllers
{
    /// <summary>
    /// Handles all operations related to hotels' images
    /// </summary>
    /// <param name="hotelImageService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/hotel-images")]
    [ApiController]
    public class HotelImageController(IService<HotelImageEntity, HotelImage> hotelImageService, IMapper mapper, ILogger<HotelImageController> logger)
        : ControllerBase
    {
        /// <summary>
        /// Gets a list of all hotels' images in the database
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

            logger.LogInformation("Calling GetAll method on the hotel image service..");
            var hotelImageEntities = await hotelImageService.GetAllAsync(pageSize, pageNumber);

            var hotelImageDtos = mapper.Map<IEnumerable<HotelImageReadDto>>(hotelImageEntities);

            logger.LogInformation("Returning the results back to user..");
            return Ok(hotelImageDtos);
        }

        /// <summary>
        /// Deletes a hotel image from the database
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
            logger.LogInformation("Calling delete method on the hotel image service..");
            var isDeleted = await hotelImageService.DeleteAsync(id);
            if (!isDeleted)
            {
                logger.LogError("Image with id {Id} does not exist.", id);
                return NotFound($"No image with id {id} exist in the database!");
            }

            await hotelImageService.SaveAsync();
            logger.LogInformation("Image with id {Id} was deleted succefully.", id);

            return Ok($"Image with id {id} has been deleted successfully!");
        }
    }
}
