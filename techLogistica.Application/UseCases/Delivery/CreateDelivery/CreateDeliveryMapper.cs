using AutoMapper;


public sealed class CreateDeliveryMapper : Profile
{
    public CreateDeliveryMapper()
    {
        CreateMap<CreateDeliveryRequest, Delivery>();
        CreateMap<Delivery, CreateDeliveryResponse>();
    }
}
