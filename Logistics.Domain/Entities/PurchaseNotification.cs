using Logistica.Domain.Entities;

namespace Logistics.Domain.Entities
{
    public class PurchaseNotification : BaseEntity
    {
        public Guid NotificationId { get; set; }
        public string? RecipientData { get; set; }
        public Product? ProductData { get; set; }
    }

}
