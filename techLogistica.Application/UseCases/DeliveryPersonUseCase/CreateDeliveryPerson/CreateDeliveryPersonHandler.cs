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
            // Lógica para lidar com a criação de um entregador

            // Exemplo: Mapear a requisição para a entidade de entregador
            var deliveryPerson = mapper.Map<DeliveryPerson>(request);

            // Exemplo: Salvar no repositório
            unitOfWork.DeliveryPersonRepository.Create(deliveryPerson);

            // Exemplo: Commit das alterações no banco de dados
            await unitOfWork.Commit(cancellationToken);

            // Exemplo: Mapear a entidade de entregador para a resposta
            var response = mapper.Map<CreateDeliveryPersonResponse>(deliveryPerson);

            return response;
        }
    }
}
