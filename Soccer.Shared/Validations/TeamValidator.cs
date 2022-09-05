using FluentValidation;
using Soccer.Shared.Entities;

namespace Soccer.Shared.Validations;

public class TeamValidator : AbstractValidator<Team>
{
    public TeamValidator()
    {
        RuleFor(t => t.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(t => t.Country).NotEmpty().WithMessage("Country is required").MaximumLength(20).WithMessage("Country must be less than 20 characters");
    }
}

