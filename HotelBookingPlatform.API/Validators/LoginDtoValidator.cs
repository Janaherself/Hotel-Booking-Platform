using FluentValidation;
using HotelBookingPlatform.API.DTOs;

namespace HotelBookingPlatform.API.Validators
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required!")
                .EmailAddress().WithMessage("Invalid email format!");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required!")
                .MinimumLength(8).WithMessage("Password must have at least 8 characters!")
                .MaximumLength(64).WithMessage("Password must have at most 64 characters!");
        }
    }
}
