using MediatR;
using techLogistica.Domain.Entities;

public sealed record CreateRecipientRequest(
    string RecipientName,
    Guid RecipientId, string RecipientAddress, string RecipientZipCode) :
    IRequest<CreateRecipientResponse>;
