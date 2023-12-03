using AutoMapper;


public sealed class CreateDeliveryPersonMapper : Profile
{
    public CreateDeliveryPersonMapper()
    {
        CreateMap<CreateDeliveryPersonRequest, DeliveryPerson>();
        CreateMap<DeliveryPerson, CreateDeliveryPersonResponse>();
    }
}
