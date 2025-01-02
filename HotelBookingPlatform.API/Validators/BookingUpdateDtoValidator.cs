using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class BookingUpdateDtoValidator : AbstractValidator<BookingUpdateDto>
    {
        public BookingUpdateDtoValidator()
        {
            RuleFor(x => x.TotalPrice)
                .GreaterThan(0).WithMessage("Price can't have negative value!");

            RuleFor(x => x.CheckInDate)
                .GreaterThan(DateOnly.FromDateTime(DateTime.Now)).WithMessage("Check-in date can't be in the past!");

            RuleFor(x => x)
                .Must(x => x.CheckOutDate > x.CheckInDate).WithMessage("Check-out date must be later than the check-in date!");
        }
    }
}
