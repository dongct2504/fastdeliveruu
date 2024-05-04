using FastDeliveruu.Application.Common.Behaviors;
using FluentValidation;

namespace FastDeliveruu.Application.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
{
    public CreateRestaurantCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(126);

        RuleFor(x => x.Description)
            .NotEmpty();

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .Must(ValidateForRequest.ValidPhoneNumber);

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