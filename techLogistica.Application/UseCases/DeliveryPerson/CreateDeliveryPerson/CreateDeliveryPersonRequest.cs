using MediatR;
using System;
using techLogistica.Domain.Entities;

public sealed record CreateDeliveryPersonRequest(
    string DeliveryPersonName,
    string DeliveryPersonPhone,
    string DeliveryLicensePlate) : IRequest<CreateDeliveryPersonResponse>;

