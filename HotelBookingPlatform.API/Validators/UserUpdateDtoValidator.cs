using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateDtoValidator()
        {
            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Role is required!")
                .Must(x => x!.Equals("Admin") || x.Equals("User")).WithMessage("Role must be either an admin or a user!");
        }
    }
}
