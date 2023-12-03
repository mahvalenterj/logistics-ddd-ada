using MediatR;
using System;

public sealed record CreateDeliveryRequest(
    string Message,
    Guid Id,
    DateTime DeliveryDate,
    Guid PurchaseNotificationId,
    Guid ShippingId,
    Guid DeliveryPersonId) : IRequest<CreateDeliveryResponse>;

