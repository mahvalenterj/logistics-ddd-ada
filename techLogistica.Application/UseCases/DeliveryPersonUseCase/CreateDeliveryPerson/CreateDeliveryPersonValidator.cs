using FluentValidation;
using System;

namespace techLogistica.Application.UseCases.DeliveryPerson.CreateDeliveryPerson
{
    public class DeliveryPersonValidator : AbstractValidator<CreateDeliveryPersonRequest>
    {
        public DeliveryPersonValidator()
        {
            RuleFor(x => x.DeliveryPersonName)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(x => x.DeliveryPersonPhone)
                .NotEmpty()
                .MaximumLength(20); 

            RuleFor(x => x.DeliveryLicensePlate)
                .NotEmpty()
                .MaximumLength(15); 

        
        }
    }
}
