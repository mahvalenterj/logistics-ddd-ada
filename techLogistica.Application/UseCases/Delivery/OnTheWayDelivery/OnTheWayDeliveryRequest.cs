using System;
using MediatR;

public sealed record OnTheWayDeliveryRequest (
      
    Guid DeliveryId,
    Guid DeliveryPersonId
    ) : IRequest<OnTheWayDeliveryResponse>;