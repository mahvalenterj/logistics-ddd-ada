using FluentValidation;
using System;

public class DeliveryPersonValidator : AbstractValidator<CreateDeliveryPersonRequest>
{
    public DeliveryPersonValidator()
    {
        RuleFor(x => x.Message)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(x => x.DeliveryDate)
            .NotEmpty();

        RuleFor(x => x.PurchaseNotificationId)
            .NotEmpty();

        RuleFor(x => x.ShippingId)
            .NotEmpty();

        RuleFor(x => x.DeliveryPersonId)
            .NotEmpty();
    }
}

