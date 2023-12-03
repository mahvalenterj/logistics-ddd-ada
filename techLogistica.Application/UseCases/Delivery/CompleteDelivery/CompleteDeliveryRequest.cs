using System;
using MediatR;

public sealed record CompleteDeliveryRequest (
    Guid Id
    ) : IRequest<CompleteDeliveryResponse>;