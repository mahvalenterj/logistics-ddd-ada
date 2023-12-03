﻿using AutoMapper;


public sealed class CreateDeliveryPersonMapper : Profile
{
    public CreateDeliveryPersonMapper()
    {
        CreateMap<CreateDeliveryPersonRequest, Delivery>();
        CreateMap<Delivery, CreateDeliveryPersonResponse>();
    }
}
