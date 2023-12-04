using AutoMapper;

namespace techLogistica.Application.UseCases.DeliveryPerson.CreateDeliveryPerson
{
    public sealed class CreateDeliveryPersonMapper : Profile
    {
        public CreateDeliveryPersonMapper()
        {
            CreateMap<CreateDeliveryPersonRequest, DeliveryPerson>();
            CreateMap<DeliveryPerson, CreateDeliveryPersonResponse>();
        }
    }
}