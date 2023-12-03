using System;
using FluentValidation;

public class AcceptDeliveryValidator : AbstractValidator<AcceptDeliveryRequest>
{
    public AcceptDeliveryValidator()
    {
        RuleFor(delivery => delivery.DeliveryPersonId)
             .NotEmpty().WithMessage("DeliveryPerson ID is required.");
    }
}
