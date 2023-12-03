using FluentValidation;

public class DeliveryValidator : AbstractValidator<CreateDeliveryRequest>
{
    public DeliveryValidator()
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

