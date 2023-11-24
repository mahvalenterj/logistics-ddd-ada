using MediatR;
using techLogistica.Domain.Entities;

public sealed record CreateRecipientRequest(
    string RecipientName,
    string RecipientAddress, string RecipientZipCode) :
    IRequest<CreateRecipientResponse>;
