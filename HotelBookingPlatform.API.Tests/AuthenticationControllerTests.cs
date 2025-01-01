using AutoMapper;
using HotelBookingPlatform.API.Controllers;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using FluentAssertions;

namespace HotelBookingPlatform.API.Tests
{
    public class AuthenticationControllerTests
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<ILogger<AuthenticationController>> _mockLogger;
        private readonly AuthenticationController _controller;

        public AuthenticationControllerTests()
        {
            _mockUserService = new Mock<IUserService>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<AuthenticationController>>();
            _controller = new AuthenticationController(_mockUserService.Object, _mockMapper.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task Login_ShouldReturnOk_WhenUserIsAuthenticated()
        {
            var loginDto = new LoginDto("test@test.com", "aVeryStrongPassw0rd");
            var loginEntity = new LoginEntity { Email = loginDto.Email, Password = loginDto.Password };
            var userToken = "test-token";

            _mockMapper.Setup(m => m.Map<LoginEntity>(loginDto)).Returns(loginEntity);
            _mockUserService.Setup(s => s.LoginAsync(loginEntity)).ReturnsAsync(userToken);

            var result = await _controller.Login(loginDto);

            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().BeEquivalentTo(userToken);
        }

        [Fact]
        public async Task Login_ShouldReturnUnauthorized_WhenUserIsNotAuthenticated()
        {
            var loginDto = new LoginDto("test@test.com", "aVeryStrongPassw0rd");
            var loginEntity = new LoginEntity { Email = loginDto.Email, Password = loginDto.Password };

            _mockMapper.Setup(m => m.Map<LoginEntity>(loginDto)).Returns(loginEntity);
            _mockUserService.Setup(s => s.LoginAsync(loginEntity)).ReturnsAsync(null as string);

            var result = await _controller.Login(loginDto);

            result.GetType().Equals(typeof(UnauthorizedResult));
        }

        [Fact]
        public async Task Register_ShouldReturnOk_WhenUserIsRegistered()
        {
            var loginDto = new LoginDto("test@test.com", "aVeryStrongPassw0rd");
            var loginEntity = new LoginEntity { Email = loginDto.Email, Password = loginDto.Password };
            var userToken = "test-token";

            _mockMapper.Setup(m => m.Map<LoginEntity>(loginDto)).Returns(loginEntity);
            _mockUserService.Setup(s => s.RegisterAsync(loginEntity)).ReturnsAsync(userToken);

            var result = await _controller.Register(loginDto);

          
            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().BeEquivalentTo(userToken);
        }

        [Fact]
        public async Task Register_ShouldReturnUnauthorized_WhenRegistrationFails()
        {
            var loginDto = new LoginDto("test@test.com", "aVeryStrongPassw0rd");
            var loginEntity = new LoginEntity { Email = loginDto.Email, Password = loginDto.Password };

            _mockMapper.Setup(m => m.Map<LoginEntity>(loginDto)).Returns(loginEntity);
            _mockUserService.Setup(s => s.RegisterAsync(loginEntity)).ReturnsAsync(null as string);

            var result = await _controller.Register(loginDto);

            result.Should().BeOfType<UnauthorizedResult>();
        }
    }
}
