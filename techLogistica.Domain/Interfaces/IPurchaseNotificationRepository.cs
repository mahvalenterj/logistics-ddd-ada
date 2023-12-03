using System;
using System.Threading;
using System.Threading.Tasks;


namespace techLogistica.Domain.Interfaces
{
    public interface IPurchaseNotificationRepository : IBaseRepository<PurchaseNotification>
    {
        Task<PurchaseNotification> GetByIdAsync(Guid purchasenotificationId, CancellationToken cancellationToken);
    }
}
