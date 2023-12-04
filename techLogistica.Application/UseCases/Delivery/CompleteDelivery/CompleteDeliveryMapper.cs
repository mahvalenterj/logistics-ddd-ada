using System;
using AutoMapper;
using techLogistica.Domain.Entities;


public class CompleteDeliveryMapper : Profile
{
	public CompleteDeliveryMapper()
	{
        CreateMap<CompleteDeliveryRequest, Delivery>();
        CreateMap<Delivery, CompleteDeliveryResponse>();
    }
}

