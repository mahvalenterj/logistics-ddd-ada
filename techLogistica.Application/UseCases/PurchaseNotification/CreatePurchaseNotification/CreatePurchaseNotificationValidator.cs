using System;
using FluentValidation;

public class CreatePurchaseNotificationValidator : AbstractValidator<CreatePurchaseNotificationRequest>
{
    public CreatePurchaseNotificationValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();

        RuleFor(x => x.PurchaseDescription)
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(x => x.RecipientName)
            .NotEmpty();

        RuleFor(x => x.RecipientCep)
            .NotEmpty();
    }
}
