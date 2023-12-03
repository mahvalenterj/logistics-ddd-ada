using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

public class CreateDeliveryHandler :
       IRequestHandler<CreateDeliveryRequest, CreateDeliveryResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeliveryRepository _deliveryRepository;
    private readonly IMapper _mapper;

    public CreateDeliveryHandler(IUnitOfWork unitOfWork,
        IDeliveryRepository deliveryRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _deliveryRepository = deliveryRepository;
        _mapper = mapper;
    }

    public async Task<CreateDeliveryResponse> Handle(CreateDeliveryRequest request,
        CancellationToken cancellationToken)
    {
        var delivery = _mapper.Map<Delivery>(request);

        _deliveryRepository.Create(delivery);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateDeliveryResponse>(delivery);
    }
}
