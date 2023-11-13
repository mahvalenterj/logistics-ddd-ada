using FluentValidation;

public class PurchaseNotificationValidator : AbstractValidator<PurchaseNotification>
{
    public PurchaseNotificationValidator()
    {
        RuleFor(x => x.Message)
            .NotEmpty()
            .MaximumLength(255);  // Ajuste o comprimento conforme necessário

        RuleFor(x => x.TotalValue)
            .GreaterThan(0);  // Ajuste conforme necessário

        RuleFor(x => x.RecipientId)
            .NotEmpty();  // Ajuste conforme necessário

        RuleFor(x => x.ProductId)
            .NotEmpty();  // Ajuste conforme necessário

        RuleFor(x => x.ProductName)
            .NotEmpty()
            .MaximumLength(100);  // Ajuste o comprimento conforme necessário

        RuleFor(x => x.ProductQuantity)
            .GreaterThan(0);  // Ajuste conforme necessário

        RuleFor(x => x.ProductWeight)
            .GreaterThanOrEqualTo(0);  // Ajuste conforme necessário

        RuleFor(x => x.RecipientAddress)
            .NotEmpty()
            .MaximumLength(255);  // Ajuste o comprimento conforme necessário

        RuleFor(x => x.RecipientZipCode)
            .NotEmpty()
            .MaximumLength(20);  // Ajuste o comprimento conforme necessário
    }
}
