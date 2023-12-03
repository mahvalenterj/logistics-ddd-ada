using System;
using AutoMapper;


public class CompleteDeliveryMapper : Profile
{
	public CompleteDeliveryMapper()
	{
        CreateMap<CompleteDeliveryRequest, Delivery>();
        CreateMap<Delivery, CompleteDeliveryResponse>();
    }
}

