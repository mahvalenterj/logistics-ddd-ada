using MediatR;
using System;

namespace techLogistica.Application.UseCases.Shipping.CalculateShipping
{
    public sealed record CalculateShippingRequest(Guid Id, decimal ShippingCost) :
        IRequest<CalculateShippingResponse>;

}