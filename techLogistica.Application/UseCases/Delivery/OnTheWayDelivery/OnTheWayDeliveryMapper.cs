using System;
using AutoMapper;


public class OnTheWayDeliveryMapper : Profile
{
	public OnTheWayDeliveryMapper()
	{
        CreateMap<OnTheWayDeliveryRequest, Delivery>();
        CreateMap<Delivery, OnTheWayDeliveryResponse>();
    }
}

