using AutoMapper;
using techLogistica.Domain.Entities;


public sealed class CreateDeliveryPersonMapper : Profile
{
    public CreateDeliveryPersonMapper()
    {
        CreateMap<CreateDeliveryPersonRequest, Delivery>();
        CreateMap<Delivery, CreateDeliveryPersonResponse>();
    }
}
