using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class CityCreateDtoValidator : AbstractValidator<CityCreateDto>
    {
        public CityCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("City name is required!");

            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is required!");

            RuleFor(x => x.PostOffice).NotEmpty().WithMessage("Post office is required!");

            RuleFor(x => x.NumberOfHotels).NotEmpty().WithMessage("Number of hotels is required!")
                .GreaterThan(0).WithMessage("Number of hotels must be greater than 0!");
        }
    }
}
