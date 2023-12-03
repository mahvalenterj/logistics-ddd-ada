using System;
using AutoMapper;

public class AcceptDeliveryMapper : Profile
{
    public AcceptDeliveryMapper()
    {
        CreateMap<AcceptDeliveryRequest, Delivery>();
        CreateMap<Delivery, AcceptDeliveryResponse>();
    }
}
