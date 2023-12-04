using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using techLogistica.Domain.Entities;
using techLogistica.Domain.Interfaces;


namespace techLogistica.Application.UseCases.DeliveryPerson.CreateDeliveryPerson
{
    public class CreateDeliveryPersonHandler :
    IRequestHandler<CreateDeliveryPersonRequest, CreateDeliveryPersonResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateDeliveryPersonHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateDeliveryPersonResponse> Handle(CreateDeliveryPersonRequest request,
            CancellationToken cancellationToken)
        {
           
            var deliveryPerson = mapper.Map<DeliveryPerson>(request);

         
            unitOfWork.DeliveryPersonRepository.Create(deliveryPerson);

           
            await unitOfWork.Commit(cancellationToken);

         
            var response = mapper.Map<CreateDeliveryPersonResponse>(deliveryPerson);

            return response;
        }
    }
}
