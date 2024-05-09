using FastDeliveruu.Application.Common.Behaviors;
using FluentValidation;

namespace FastDeliveruu.Application.Authentication.Commands.RegisterShipper;

public class RegisterShipperCommandValidator : AbstractValidator<RegisterShipperCommand>
{
    public RegisterShipperCommandValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty()
            .MaximumLength(128);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.DateOfBirth)
            .NotEmpty();
        
        RuleFor(x => x.Cccd)
            .NotEmpty();
        
        RuleFor(x => x.DriverLicense)
            .NotEmpty();

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .Must(ValidateForRequest.BeValidPhoneNumber).WithMessage("Invalid phone number.");

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(128);

        RuleFor(x => x.Password)
            .NotEmpty();

        RuleFor(x => x.Address)
            .NotEmpty()
            .MaximumLength(128);

        RuleFor(x => x.Ward)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.District)
            .NotEmpty()
            .MaximumLength(30);

        RuleFor(x => x.City)
            .NotEmpty()
            .MaximumLength(30);
    }
}