using System;
using FluentValidation;
using techLogistica.Application.UseCases.Shipping.CalculateShipping;

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
