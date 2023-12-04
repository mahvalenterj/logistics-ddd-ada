using System;
using System.Threading;
using System.Threading.Tasks;
using techLogistica.Domain.Entities;


namespace techLogistica.Domain.Interfaces
{
    public interface IPurchaseNotificationRepository : IBaseRepository<PurchaseNotification>
    {
        Task<PurchaseNotification> GetByIdAsync(Guid purchasenotificationId, CancellationToken cancellationToken);
    }
}
