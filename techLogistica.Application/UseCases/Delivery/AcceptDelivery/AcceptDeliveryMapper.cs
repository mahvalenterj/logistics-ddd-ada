using System;
using AutoMapper;
using techLogistica.Domain.Entities;

public class AcceptDeliveryMapper : Profile
{
    public AcceptDeliveryMapper()
    {
        CreateMap<AcceptDeliveryRequest, Delivery>();
        CreateMap<Delivery, AcceptDeliveryResponse>();
    }
}
