using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class BookingCreateDtoValidator : AbstractValidator<BookingCreateDto>
    {
        public BookingCreateDtoValidator()
        {
            RuleFor(x => x.TotalPrice)
                .NotEmpty().WithMessage("Price is required!");

            RuleFor(x => x.CheckInDate)
                .NotEmpty().WithMessage("Check-in date is required!")
                .GreaterThan(DateOnly.FromDateTime(DateTime.Now)).WithMessage("Check-in date can't be in the past!");

            RuleFor(x => x.CheckOutDate)
                .NotEmpty().WithMessage("Check-out date is required!");

            RuleFor(x => x)
                .Must(x => x.CheckOutDate > x.CheckInDate).WithMessage("Check-out date must be later than the check-in date!");

            RuleFor(x => x.RoomIds)
                .NotEmpty().WithMessage("At least one room is required required!");
        }
    }
}
