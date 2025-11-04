using FluentValidation;

namespace FluentValidationDemonstration.Client;

public class MyViewModelValidator : AbstractValidator<MyViewModel>
{
    public MyViewModelValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Fluent validation says name is required.");

    }
}

