
using techLogistica.Domain.Entities;

public class Delivery : BaseEntity
{
    public DateTime DeliveryDate { get; set; }

    // Relacionamento com Notification
    public Guid PurchaseNotificationId { get; set; }
    public PurchaseNotification PurchaseNotification { get; set; }

    // Relacionamento com Shipping
    public Guid ShippingId { get; set; }
    public Shipping Shipping { get; set; }

    public decimal ShippingCost { get; set; }

    // Relacionamento com DeliveryPerson
    public Guid DeliveryPersonId { get; set; }
    public DeliveryPerson DeliveryPerson { get; set; }

    // Status da entrega
    public DeliveryStatus Status { get; set; }

}

// Colocar Enum de DeliveryStatus

public enum DeliveryStatus
    {
        Created,    
        Accepted,
        OnTheWay,
        Completed
    }