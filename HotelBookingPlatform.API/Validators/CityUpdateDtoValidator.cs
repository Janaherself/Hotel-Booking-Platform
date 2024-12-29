using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class CityUpdateDtoValidator : AbstractValidator<CityUpdateDto>
    {
        public CityUpdateDtoValidator()
        {
            RuleFor(x => x.NumberOfHotels).GreaterThan(0).WithMessage("Number of hotels must be greater than 0!");
        }
    }
}
