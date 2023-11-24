using MediatR;
using techLogistica.Domain.Entities;

public sealed record CreateProductRequest(
    string ProductName,
    Guid ProductId, int ProductQuantity, decimal ProductWeight) :
    IRequest<CreateProductResponse>;
