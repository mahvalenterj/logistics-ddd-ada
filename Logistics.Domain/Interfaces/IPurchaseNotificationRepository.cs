using Logistics.Domain.Entities;

namespace Logistics.Domain.Interfaces
{
    public interface IPurchaseNotificationRepository
    {
        Task Create(PurchaseNotification notification);
        Task<List<PurchaseNotification>> GetNotificationsByIdAsync(Guid notificationid);
    }
}
