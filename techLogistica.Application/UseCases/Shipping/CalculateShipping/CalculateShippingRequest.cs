using MediatR;
using System;

public sealed record CalculateShippingRequest(Guid Id, decimal ShippingCost) :
    IRequest<CalculateShippingResponse>;

