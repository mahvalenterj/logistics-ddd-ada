using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

namespace techLogistica.Application.UseCases.PurchaseNotification.DeletePurchaseNotification
{
    public class DeletePurchaseNotificationHandler :
        IRequestHandler<DeletePurchaseNotificationRequest, DeletePurchaseNotificationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPurchaseNotificationRepository _purchaseNotificationRepository;
        private readonly IMapper _mapper;

        public DeletePurchaseNotificationHandler(
            IUnitOfWork unitOfWork,
            IPurchaseNotificationRepository purchaseNotificationRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _purchaseNotificationRepository = purchaseNotificationRepository ?? throw new ArgumentNullException(nameof(purchaseNotificationRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<DeletePurchaseNotificationResponse> Handle(
            DeletePurchaseNotificationRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var purchaseNotification =
                await _purchaseNotificationRepository.Get(request.Id, cancellationToken);

            if (purchaseNotification is null)
            {
                // Not found, you might want to handle this differently (return NotFound() or similar).
                return null;
            }

            _purchaseNotificationRepository.Delete(purchaseNotification);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeletePurchaseNotificationResponse>(purchaseNotification);
        }
    }
}
