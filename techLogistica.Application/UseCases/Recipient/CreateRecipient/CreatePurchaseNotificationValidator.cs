using FluentValidation;

public class PurchaseNotificationValidator : AbstractValidator<PurchaseNotification>
{
    public PurchaseNotificationValidator()
    {
        RuleFor(x => x.Message)
            .NotEmpty()
            .MaximumLength(255); 
        RuleFor(x => x.TotalValue)
            .GreaterThan(0); 

        RuleFor(x => x.RecipientId)
            .NotEmpty();  

        RuleFor(x => x.ProductId)
            .NotEmpty();  

        RuleFor(x => x.ProductName)
            .NotEmpty()
            .MaximumLength(100); 

        RuleFor(x => x.ProductQuantity)
            .GreaterThan(0); 

        RuleFor(x => x.ProductWeight)
            .GreaterThanOrEqualTo(0);  

        RuleFor(x => x.RecipientAddress)
            .NotEmpty()
            .MaximumLength(255);  

        RuleFor(x => x.RecipientZipCode)
            .NotEmpty()
            .MaximumLength(20); 
    }
}
