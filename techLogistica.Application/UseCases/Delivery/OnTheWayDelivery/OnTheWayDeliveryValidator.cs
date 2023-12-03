using System;
using FluentValidation;

namespace techLogistica.Application.UseCases
{
    public class OnTheWayDeliveryValidator : AbstractValidator<OnTheWayDeliveryRequest>
    {
        public OnTheWayDeliveryValidator()
        {
            RuleFor(x => x.DeliveryId)
                .NotEmpty().WithMessage("Delivery ID must not be empty.")
                .NotEqual(Guid.Empty).WithMessage("Delivery ID must be a valid GUID.");


        }
    }
}