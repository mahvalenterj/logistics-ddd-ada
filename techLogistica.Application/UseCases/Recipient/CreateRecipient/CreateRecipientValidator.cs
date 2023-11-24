using FluentValidation;

public class RecipientValidator : AbstractValidator<Recipient>
{
    public RecipientValidator()
    {
                    
        RuleFor(x => x.RecipientName)
            .NotEmpty(); 

        RuleFor(x => x.RecipientAddress)
            .NotEmpty();  

        RuleFor(x => x.RecipientZipCode)
            .NotEmpty();  

    }
}
