using System;
using FluentValidation;

public class OntheWayDeliveryValidator : AbstractValidator<CompleteDeliveryRequest>
{
    public OntheWayDeliveryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Delivery ID must not be empty.")
            .NotEqual(Guid.Empty).WithMessage("Delivery ID must be a valid GUID.");

    }
}
