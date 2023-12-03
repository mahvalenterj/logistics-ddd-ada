using System;
using System.Threading;
using AutoMapper;
using MediatR;

namespace techLogistica.Application.UseCases
{
    public class OnTheWayDeliveryHandler : IRequestHandler<OnTheWayDeliveryRequest, OnTheWayDeliveryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public OnTheWayDeliveryHandler(
            IUnitOfWork unitOfWork,
            IDeliveryRepository deliveryRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public async Task<OnTheWayDeliveryResponse> Handle(OnTheWayDeliveryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var delivery = await _deliveryRepository.Get(request.DeliveryId, cancellationToken) ?? throw new InvalidOperationException("Delivery not found. The provided delivery does not exist.");

                // Verifica se o status atual permite a transição para "A caminho"
                if (delivery.Status != DeliveryStatus.Accepted)
                {
                    throw new InvalidOperationException("Cannot set status to 'A caminho' for a delivery that is not in the pending state.");
                }

                // Aqui você define o status como "A caminho"
                delivery.Status = DeliveryStatus.OnTheWay;

                // Atribui a pessoa responsável e o destino, se aplicável
                delivery.DeliveryPersonId = request.DeliveryPersonId;

                _mapper.Map(request, delivery);
                _deliveryRepository.Update(delivery);

                await _unitOfWork.Commit(cancellationToken);

                return _mapper.Map<OnTheWayDeliveryResponse>(delivery);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}