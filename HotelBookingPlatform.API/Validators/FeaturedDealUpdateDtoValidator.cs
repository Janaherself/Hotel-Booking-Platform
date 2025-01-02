using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class FeaturedDealUpdateDtoValidator : AbstractValidator<FeaturedDealUpdateDto>
    {
        public FeaturedDealUpdateDtoValidator()
        {
            RuleFor(x => x.HotelId)
               .GreaterThan(0).WithMessage("Hotel Id must be greater than 0!");

            RuleFor(x => x.OriginalPrice)
                .GreaterThan(0).WithMessage("Original price must be greater than 0!");

            RuleFor(x => x.DiscountedPrice)
                .GreaterThan(0).WithMessage("Discounted price must be greater than 0!");

            RuleFor(x => x.StartDate)
                .GreaterThan(DateTime.Now).WithMessage("Start date can't be in the past!");

            RuleFor(x => x)
                .Must(x => x.EndDate > x.StartDate).WithMessage("End date must be later than the check-in date!")
                .Must(x => x.DiscountedPrice < x.OriginalPrice).WithMessage("Discounted price must be less than original price!");
        }
    }
}
