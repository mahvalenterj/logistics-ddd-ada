using MediatR;

public sealed record GetAllPurchaseNotificationRequest : 

                   IRequest<List<GetAllPurchaseNotificationResponse>>;
