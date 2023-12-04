using MediatR;
using System;
using techLogistica.Domain.Entities;

namespace techLogistica.Application.UseCases.DeliveryPerson.CreateDeliveryPerson
{
    public sealed record CreateDeliveryPersonRequest(
    string DeliveryPersonName,
    string DeliveryPersonPhone,
    string DeliveryLicensePlate) : IRequest<CreateDeliveryPersonResponse>;

}

