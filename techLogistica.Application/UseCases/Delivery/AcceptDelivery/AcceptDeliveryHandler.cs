using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using techLogistica.Domain.Entities;
using techLogistica.Domain.Interfaces;

namespace techLogistica.Application.UseCases.DeliveryUseCase
{
    public class AcceptDeliveryHandler : IRequestHandler<AcceptDeliveryRequest, AcceptDeliveryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public AcceptDeliveryHandler(IUnitOfWork unitOfWork, IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public async Task<AcceptDeliveryResponse> Handle(AcceptDeliveryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                // Obtenção da entrega a ser aceita
                var delivery = await _deliveryRepository.GetByIdAsync(request.Id, cancellationToken)
                               ?? throw new InvalidOperationException("Delivery not found. The provided delivery does not exist.");

                // Atualização do status da entrega
                delivery.Status = DeliveryStatus.Accepted;

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
    }
}
