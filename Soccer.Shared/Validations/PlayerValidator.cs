using FluentValidation;
using Soccer.Shared.Entities;

namespace Soccer.Shared.Validations;
public class PlayerValidator : AbstractValidator<Player>
{
    public PlayerValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Name is required").MaximumLength(50).WithMessage("Name must be less than 50 characters");
        RuleFor(p => p.Nationality).NotEmpty().WithMessage("Nationality is required").MaximumLength(20).WithMessage("Nationality must be less than 20 characters");
    }
}