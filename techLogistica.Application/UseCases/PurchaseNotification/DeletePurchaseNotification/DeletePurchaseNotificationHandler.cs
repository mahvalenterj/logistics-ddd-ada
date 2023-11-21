using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;


public sealed class DeletePurchaseNotificationHandler :
                    IRequestHandler<DeletePurchaseNotificationRequest, DeletePurchaseNotificationResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPurchaseNotificationRepository _purchasenotificationRepository;
    private readonly IMapper _mapper;

    public DeletePurchaseNotificationHandler(IUnitOfWork unitOfWork,
                             IPurchaseNotificationRepository purchasenotificationRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _purchasenotificationRepository = purchasenotificationRepository;
        _mapper = mapper;
    }

    public async Task<DeletePurchaseNotificationResponse?> Handle(DeletePurchaseNotificationRequest request,
                                                 CancellationToken cancellationToken)
    {

        var purchasenotification = await _purchasenotificationRepository.Get(request.Id, cancellationToken);

        if (purchasenotification == null) return default;

        _purchasenotificationRepository.Delete(purchasenotification);
        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeletePurchaseNotificationResponse>(purchasenotification);
    }
}
