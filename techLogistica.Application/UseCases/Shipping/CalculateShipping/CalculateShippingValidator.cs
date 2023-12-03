using System;
using FluentValidation;

public class CalculateShippingValidator : AbstractValidator<CalculateShippingRequest>
{
    public CalculateShippingValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();

        RuleFor(x => x.ShippingCost)
            .NotEmpty();
            

    
    }
}
