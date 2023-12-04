using System;
using MediatR;
using techLogistica.Domain.Entities;

public sealed record AcceptDeliveryRequest(
   Guid DeliveryPersonId,
   Guid Id,
   Guid PurchaseNotificationId,
   DeliveryStatus Status

) : IRequest<AcceptDeliveryResponse>;
