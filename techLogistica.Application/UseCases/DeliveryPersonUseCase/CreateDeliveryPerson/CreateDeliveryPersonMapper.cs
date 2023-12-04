using AutoMapper;

namespace techLogistica.Application.UseCases.DeliveryPersonUseCase.CreateDeliveryPerson
{
    public class CreateDeliveryPersonMapper : Profile
    {
        public CreateDeliveryPersonMapper()
        {
            CreateMap<CreateDeliveryPersonRequest, DeliveryPerson>();
            CreateMap<DeliveryPerson, CreateDeliveryPersonResponse>();
        }
    }
}