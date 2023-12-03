using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using techLogistica.Domain.Entities;
using techLogistica.Domain.Interfaces;

namespace techLogistica.Application.UseCases
{
    //Consertar
    public class AcceptDeliveryHandler :
        IRequestHandler<AcceptDeliveryRequest, AcceptDeliveryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IDeliveryPersonRepository _deliveryPersonRepository; // Adicione esta linha
        private readonly IMapper _mapper;



        public AcceptDeliveryHandler(IUnitOfWork unitOfWork,
            IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;

        }

        public async Task<AcceptDeliveryResponse> Handle(AcceptDeliveryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                // Validação do entregador
                var deliveryPerson = await ValidateDeliveryPerson(request.DeliveryPersonId, cancellationToken);

                // Obtenção da entrega a ser aceita
                var delivery = await _deliveryRepository.GetByIdAsync(request.Id, cancellationToken) ?? throw new InvalidOperationException("Delivery not found. The provided delivery does not exist.");

                // Verificação se o entregador está livre para receber entregas
                /*bool isDeliveryPersonFree = await CheckDeliveryPersonAvailability(deliveryPerson.Id, cancellationToken);
                if (!isDeliveryPersonFree)
                {
                    throw new InvalidOperationException("Delivery person is not available to accept deliveries.");
                }*/

                // Validação ou criação da entrega
                delivery = await ValidateOrCreateDelivery(deliveryPerson.Id, cancellationToken);

                // Atualização das propriedades da entrega
                delivery.DeliveryPersonId = deliveryPerson.Id;
                delivery.Status = DeliveryStatus.Accepted;

                // Mapeamento dos dados da requisição para a entrega
                _mapper.Map(request, delivery);

                // Atualização da entrega no repositório
                _deliveryRepository.Update(delivery);

                // Commit da transação
                await _unitOfWork.Commit(cancellationToken);

                // Mapeamento da resposta
                return _mapper.Map<AcceptDeliveryResponse>(delivery);
            }
            catch (Exception)
            {

                throw; // Rejoga a exceção para cima
            }
        }

        /*private async Task<bool> CheckDeliveryPersonAvailability(Guid deliveryPersonId, CancellationToken cancellationToken)
        {
            // Adicione a lógica necessária para verificar se o entregador está livre para receber entregas
            // Retorna true se estiver livre, false caso contrário
            // Este método deve ser implementado com base nas regras de negócio específicas
            // por exemplo, verificando se o entregador não está em outra entrega no momento.
            return true; // Temporariamente retornando true para compilar
        }*/

        private async Task<DeliveryPerson> ValidateDeliveryPerson(Guid deliveryPersonId, CancellationToken cancellationToken)
        {
            var deliveryPerson = await _deliveryPersonRepository.Get(deliveryPersonId, cancellationToken);

            return deliveryPerson is null
                ? throw new InvalidOperationException("Delivery person not found. The provided delivery person does not exist.")
                : deliveryPerson;
        }

        private async Task<Delivery> ValidateOrCreateDelivery(Guid deliveryPersonId, CancellationToken cancellationToken)
        {
            // Verifique se o entregador tem uma entrega em andamento
            var existingDelivery = await _deliveryRepository.GetInProgressDeliveryByDeliveryPersonId(deliveryPersonId, cancellationToken);

            if (existingDelivery != null)
            {
                // Se o entregador já tem uma entrega em andamento, você pode adicionar lógica adicional, se necessário.
                // Por exemplo, lançar uma exceção informando que o entregador já está em uma entrega.
                throw new InvalidOperationException("Delivery person is already assigned to an ongoing delivery.");
            }

            // Se não houver uma entrega em andamento, crie uma nova entrega
            var newDelivery = new Delivery
            {
                // Atribua as propriedades necessárias da nova entrega
                // Certifique-se de definir as propriedades conforme necessário com base nas regras de negócio
                DeliveryPersonId = deliveryPersonId,
                Status = DeliveryStatus.Created,
                // ... outras propriedades ...
            };

            // Adicione a nova entrega ao repositório
            _deliveryRepository.Create(newDelivery);

            // Commit da transação
            await _unitOfWork.Commit(cancellationToken);

            // Retorne a entrega associada à entrega
            return newDelivery;
        }

    }
}