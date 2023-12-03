using System;
using MediatR;

public sealed record AcceptDeliveryRequest(
   Guid DeliveryPersonId,
   Guid Id,
   Guid PurchaseNotificationId,
   DeliveryStatus Status

) : IRequest<AcceptDeliveryResponse>;
