using MediatR;
using Logistics.Domain.Entities;

public sealed record CreateNotificationRequest(
    Guid NotificationId,
    string RecipientData,
    Product ProductData
    
    ) : IRequest<CreateNotificationResponse>;
