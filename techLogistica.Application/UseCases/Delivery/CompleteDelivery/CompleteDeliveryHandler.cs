using System;
using System.Threading;
using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

public class CompleteDeliveryHandler : IRequestHandler<CompleteDeliveryRequest, CompleteDeliveryResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeliveryRepository _deliveryRepository;
    private readonly IMapper _mapper;

    public CompleteDeliveryHandler(
        IUnitOfWork unitOfWork,
        IDeliveryRepository deliveryRepository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _deliveryRepository = deliveryRepository;
        _mapper = mapper;
    }

    public async Task<CompleteDeliveryResponse> Handle(CompleteDeliveryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var delivery = await _deliveryRepository.Get(request.Id, cancellationToken);
            if (delivery is null)
            {
                throw new InvalidOperationException("Delivery not found. The provided delivery does not exist.");
            }

            delivery.Status = DeliveryStatus.Completed;

            _mapper.Map(request, delivery);
            _deliveryRepository.Update(delivery);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CompleteDeliveryResponse>(delivery);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
