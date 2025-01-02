using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class HotelUpdateDtoValidator : AbstractValidator<HotelUpdateDto>
    {
        public HotelUpdateDtoValidator()
        {
            RuleFor(x => x.CityId)
            .NotEmpty().WithMessage("City Id is required!")
            .GreaterThan(0).WithMessage("City Id must be greater than 0!");
        }
    }
}
