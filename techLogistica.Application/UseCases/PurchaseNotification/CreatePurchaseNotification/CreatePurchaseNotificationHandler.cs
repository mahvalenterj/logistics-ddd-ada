using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

public class CalculateShippingHandler :
       IRequestHandler<CreatePurchaseNotificationRequest, CalculateShippingResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPurchaseNotificationRepository _purchasenotificationRepository;
    private readonly IMapper _mapper;

    public CalculateShippingHandler(IUnitOfWork unitOfWork,
        IPurchaseNotificationRepository purchasenotificationRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _purchasenotificationRepository = purchasenotificationRepository;
        _mapper = mapper;
    }

    public async Task<CalculateShippingResponse> Handle(CreatePurchaseNotificationRequest request,
        CancellationToken cancellationToken)
    {
        var purchasenotification = _mapper.Map<PurchaseNotification>(request);

        _purchasenotificationRepository.Create(purchasenotification);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CalculateShippingResponse>(purchasenotification);
    }
}
