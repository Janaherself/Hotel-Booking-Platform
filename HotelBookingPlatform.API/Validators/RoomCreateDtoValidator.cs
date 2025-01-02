using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class RoomCreateDtoValidator : AbstractValidator<RoomCreateDto>
    {
        public RoomCreateDtoValidator()
        {
            RuleFor(x => x.HotelId)
                .NotEmpty().WithMessage("Hotel Id is required!")
                .GreaterThan(0).WithMessage("Hotel Id must be greater than 0!");

            RuleFor(x => x.Number)
                .NotEmpty().WithMessage("Room number is required!");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("Price is required!")
                .GreaterThan(0).WithMessage("Price must be greater than 0!");

            RuleFor(x => x.ChildrenCapacity)
                .NotEmpty().WithMessage("Children capacity is required!")
                .LessThan(4).WithMessage("Children capacity must be less than 4!");

            RuleFor(x => x.AdultsCapacity)
                .NotEmpty().WithMessage("Adults capacity is required!")
                .GreaterThan(0).WithMessage("Adults capacity must be greater than 0!");

            RuleFor(x => x.IsAvailable)
                .NotEmpty().WithMessage("Availability is required!");
        }
    }
}
