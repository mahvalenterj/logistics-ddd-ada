using MediatR;
using techLogistica.Domain.Entities;

public sealed record CreatePurchaseNotificationRequest(
    string Message, decimal TotalValue,
    Guid Id, string ProductName, Product ProductQuantity, Product ProductWeight,
    Recipient RecipientAddress, Recipient RecipientZipCode) :
    IRequest<CreatePurchaseNotificationResponse>;
