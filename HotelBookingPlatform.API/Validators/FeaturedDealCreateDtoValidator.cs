using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class FeaturedDealCreateDtoValidator : AbstractValidator<FeaturedDealCreateDto>
    {
        public FeaturedDealCreateDtoValidator()
        {
            RuleFor(x => x.HotelId)
               .NotEmpty().WithMessage("Hotel Id is required!")
               .GreaterThan(0).WithMessage("Hotel Id must be greater than 0!");

            RuleFor(x => x.OriginalPrice)
                .NotEmpty().WithMessage("Original price is required!")
                .GreaterThan(0).WithMessage("Original price must be greater than 0!");

            RuleFor(x => x.DiscountedPrice)
                .NotEmpty().WithMessage("Discounted price is required!")
                .GreaterThan(0).WithMessage("Discounted price must be greater than 0!");

            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("Start date is required!")
                .GreaterThan(DateTime.Now).WithMessage("Start date can't be in the past!");

            RuleFor(x => x.EndDate)
                .NotEmpty().WithMessage("End date is required!");

            RuleFor(x => x)
                .Must(x => x.EndDate > x.StartDate).WithMessage("End date must be later than the check-in date!")
                .Must(x => x.DiscountedPrice < x.OriginalPrice).WithMessage("Discounted price must be less than original price!");
        }
    }
}
