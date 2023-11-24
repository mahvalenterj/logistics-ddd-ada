using FluentValidation;
using techLogistica.Domain.Entities;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
                    
        RuleFor(x => x.ProductName)
            .NotEmpty(); 

        RuleFor(x => x.ProductQuantity)
            .NotEmpty();  

        RuleFor(x => x.ProductWeight)
            .NotEmpty();  

    }
}
