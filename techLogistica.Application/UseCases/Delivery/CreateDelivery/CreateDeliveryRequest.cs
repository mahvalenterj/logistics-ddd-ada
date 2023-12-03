using MediatR;
using System;

public sealed record CreateDeliveryPersonRequest(
    string Message,
    Guid Id,
    DateTime DeliveryDate,
    Guid PurchaseNotificationId,
    Guid ShippingId,
    Guid DeliveryPersonId) : IRequest<CreateDeliveryPersonResponse>;

