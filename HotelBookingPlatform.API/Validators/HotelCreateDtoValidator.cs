using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class HotelCreateDtoValidator : AbstractValidator<HotelCreateDto>
    {
        public HotelCreateDtoValidator()
        {
            RuleFor(x => x.CityId)
                .NotEmpty().WithMessage("City Id is required!")
                .GreaterThan(0).WithMessage("City Id must be greater than 0!");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Hotel Name is required!");

            RuleFor(x => x.Rating)
                .NotEmpty().WithMessage("Rating is required!")
                .GreaterThan(0).WithMessage("Rating must be greater than 0!")
                .LessThanOrEqualTo(5).WithMessage("Rating must be less than  or equal to 5!");

            RuleFor(x => x.Owner)
                .NotEmpty().WithMessage("Owner is required!");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Location is required!");
        }
    }
}
