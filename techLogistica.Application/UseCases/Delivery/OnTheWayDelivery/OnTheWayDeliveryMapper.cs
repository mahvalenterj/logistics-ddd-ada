using System;
using AutoMapper;
using techLogistica.Domain.Entities;


public class OnTheWayDeliveryMapper : Profile
{
	public OnTheWayDeliveryMapper()
	{
        CreateMap<OnTheWayDeliveryRequest, Delivery>();
        CreateMap<Delivery, OnTheWayDeliveryResponse>();
    }
}

