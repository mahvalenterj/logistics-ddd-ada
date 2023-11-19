using MediatR;
using techLogistica.Domain.Entities;

public sealed record CreatePurchaseNotificationRequest(
    string Message, decimal TotalValue,
    Guid RecipientId, Guid ProductId,
    string ProductName, int ProductQuantity, decimal ProductWeight,
    string RecipientAddress, string RecipientZipCode) :
    IRequest<CreatePurchaseNotificationResponse>;
