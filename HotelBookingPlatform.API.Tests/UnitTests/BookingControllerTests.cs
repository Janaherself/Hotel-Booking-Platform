using AutoMapper;
using FluentAssertions;
using HotelBookingPlatform.API.Controllers;
using HotelBookingPlatform.API.DTOs;
using HotelBookingPlatform.Domain.DomainEntities;
using HotelBookingPlatform.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Security.Claims;

namespace HotelBookingPlatform.API.Tests.UnitTests
{
    public class BookingControllerTests
    {
        private readonly Mock<IBookingService> _mockBookingService;
        private readonly Mock<IMapper> _mockMapper;
        private readonly Mock<ILogger<BookingController>> _mockLogger;
        private readonly BookingController _controller;

        public BookingControllerTests()
        {
            _mockBookingService = new Mock<IBookingService>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<BookingController>>();
            _controller = new BookingController(_mockBookingService.Object, _mockMapper.Object, _mockLogger.Object)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext()
                }
            };
        }

        [Fact]
        public async Task GetAll_ShouldReturnOk_WhenValidRequest()
        {
            int pageSize = 10, pageNumber = 1;
            var bookings = new List<BookingEntity>();
            var bookingDtos = new List<BookingReadDto>();

            _mockBookingService.Setup(s => s.GetAllAsync(pageSize, pageNumber)).ReturnsAsync(bookings);
            _mockMapper.Setup(m => m.Map<IEnumerable<BookingReadDto>>(bookings)).Returns(bookingDtos);

            var result = await _controller.GetAll(pageSize, pageNumber);

            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().BeEquivalentTo(bookingDtos);
        }

        [Fact]
        public async Task GetAll_ShouldReturnBadRequest_WhenPageSizeOrPageNumberIsInvalid()
        {
            var result = await _controller.GetAll(-1, 0);

            result.Should().BeOfType<BadRequestObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async Task GetById_ShouldReturnOk_WhenBookingExists()
        {
            int bookingId = 1;
            var bookingEntity = new BookingEntity();
            var bookingDto = new BookingReadDto(1, 1, new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 10), 2500, "Completed", [], new DateTime(), null);

            _mockBookingService.Setup(s => s.GetByIdAsync(bookingId)).ReturnsAsync(bookingEntity);
            _mockMapper.Setup(m => m.Map<BookingReadDto>(bookingEntity)).Returns(bookingDto);

            var result = await _controller.GetById(bookingId);

            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().BeEquivalentTo(bookingDto);
        }

        [Fact]
        public async Task Add_ShouldReturnUnauthorized_WhenUserIdClaimIsInvalid()
        {
            var booking = new BookingCreateDto(new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 9), 1220, [1, 2]);

            var result = await _controller.Add(booking);

            result.Should().BeOfType<UnauthorizedObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status401Unauthorized);
        }

        [Fact]
        public async Task Add_ShouldReturnOk_WhenBookingIsAddedSuccessfully()
        {
            var bookingCreateDto = new BookingCreateDto(new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 9), 1220, [1]);
            var bookingEntity = new BookingEntity();

            _controller.ControllerContext.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity([new("UserId", "1")]));
            _mockMapper.Setup(m => m.Map<BookingEntity>(bookingCreateDto)).Returns(bookingEntity);

            var result = await _controller.Add(bookingCreateDto);

            result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public async Task Update_ShouldReturnUnauthorized_WhenUserIdClaimIsInvalid()
        {
            var result = await _controller.Update(1, new BookingUpdateDto(new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 9), 1220, null));

            result.Should().BeOfType<UnauthorizedObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status401Unauthorized);
        }

        [Fact]
        public async Task Update_ShouldReturnOk_WhenBookingIsUpdatedSuccessfully()
        {
            var bookingUpdateDto = new BookingUpdateDto(new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 9), 1220, null);
            var bookingEntity = new BookingEntity();

            _controller.ControllerContext.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity([new("UserId", "1")]));
            _mockMapper.Setup(m => m.Map<BookingEntity>(bookingUpdateDto)).Returns(bookingEntity);
            _mockBookingService.Setup(s => s.UpdateAsync(1, bookingEntity, 1)).ReturnsAsync(true);

            var result = await _controller.Update(1, bookingUpdateDto);

            result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public async Task Delete_ShouldReturnUnauthorized_WhenBookingDoesNotBelongToUser()
        {
            _controller.ControllerContext.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity([new("UserId", "1")]));
            _mockBookingService.Setup(s => s.DeleteAsync(1, 1)).ReturnsAsync(false);

            var result = await _controller.Delete(1);

            result.Should().BeOfType<UnauthorizedObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status401Unauthorized);
        }

        [Fact]
        public async Task Delete_ShouldReturnOk_WhenBookingIsDeletedSuccessfully()
        {
            _controller.ControllerContext.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity([new("UserId", "1")]));
            _mockBookingService.Setup(s => s.DeleteAsync(1, 1)).ReturnsAsync(true);

            var result = await _controller.Delete(1);

            result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public async Task Update_ShouldReturnUnauthorized_IfBookingDoesNotBelongToUser()
        {
            int bookingId = 1;
            var bookingUpdateDto = new BookingUpdateDto(new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 9), 1220, null);
            var bookingEntity = new BookingEntity();
            var userId = 123;

            _mockMapper.Setup(m => m.Map<BookingEntity>(bookingUpdateDto)).Returns(bookingEntity);
            _mockBookingService.Setup(s => s.UpdateAsync(bookingId, bookingEntity, userId)).ReturnsAsync(false);

            _controller.ControllerContext.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity([new("UserId", "123")]));

            var result = await _controller.Update(bookingId, bookingUpdateDto);

            result.Should().BeOfType<UnauthorizedObjectResult>();
        }

        [Fact]
        public async Task Controller_ShouldReturnUnauthorized_ForExpiredToken()
        {
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity())
                }
            };

            var bookingCreateDto = new BookingCreateDto(new DateOnly(2024, 9, 9), new DateOnly(2024, 9, 9), 1220, [1]);

            var result = await _controller.Add(bookingCreateDto);

            result.Should().BeOfType<UnauthorizedObjectResult>();
        }
    }
}
