using AutoMapper;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingPlatform.API.Controllers
{
    /// <summary>
    /// Handles the logic of authenticating users (login/register)
    /// </summary>
    /// <param name="userService"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController(IUserService userService, IMapper mapper, ILogger<AuthenticationController> logger) : ControllerBase
    {
        /// <summary>
        /// Signs in an existing user to the API
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        [Route("login")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var login = mapper.Map<LoginEntity>(loginDto);

            logger.LogInformation("Calling the login method in the user service..");
            var userToken = await userService.LoginAsync(login);
            if (userToken == null)
            {
                logger.LogInformation("User with email {Email} couldn't be authenticated.", login.Email);
                return Unauthorized();
            }

            logger.LogInformation("Returning the token back to user..");
            return Ok(userToken);
        }

        /// <summary>
        /// Signs up a new user in the API
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        [Route("register")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Register([FromBody] LoginDto loginDto)
        {
            var login = mapper.Map<LoginEntity>(loginDto);

            logger.LogInformation("Calling the register method in the user service..");
            var userToken = await userService.RegisterAsync(login);
            if (userToken == null)
            {
                logger.LogInformation("User with email {Email} couldn't be registered.", login.Email);
                return Unauthorized();
            }

            logger.LogInformation("Returning the token back to user..");
            return Ok(userToken);
        }
    }
}
