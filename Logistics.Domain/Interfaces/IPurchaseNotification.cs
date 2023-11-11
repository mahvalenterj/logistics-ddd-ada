using Logistics.Domain.Entities;

public interface IPurchaseNotificationService
{
    // Método para processar a notificação de compra
    Task ProcessPurchaseNotification(PurchaseNotification purchaseNotification, CancellationToken cancellationToken);
}