using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class RoomUpdateDtoValidator : AbstractValidator<RoomUpdateDto>
    {
        public RoomUpdateDtoValidator()
        {
            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Price must be greater than 0!");

            RuleFor(x => x.ChildrenCapacity)
                .LessThan(4).WithMessage("Children capacity must be less than 4!");

            RuleFor(x => x.AdultsCapacity)
                .GreaterThan(0).WithMessage("Adults capacity must be greater than 0!");
        }
    }
}
