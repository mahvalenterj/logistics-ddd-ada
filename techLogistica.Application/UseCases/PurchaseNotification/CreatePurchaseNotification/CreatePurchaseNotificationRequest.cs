using MediatR;


public sealed record CreatePurchaseNotificationRequest(
    string RecipientName,
    string PurchaseDescription, 
    string RecipientCep,
    Guid Id
    ) :
    IRequest<CalculateShippingResponse>;
