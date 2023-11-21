using MediatR;

public sealed record DeletePurchaseNotificationRequest(Guid Id)
                  : IRequest<DeletePurchaseNotificationResponse>;
