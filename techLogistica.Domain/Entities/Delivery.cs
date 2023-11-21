using techLogistica.Domain.Entities;

public class Delivery : BaseEntity
{
    // Propriedades específicas da entrega

    public Recipient RecipientName { get; set; }
    public Recipient RecipientZipCode { get; set; }
    public Product Produto { get; set; }
    public Product ProductQuantity { get; set; }
    public Product ProductWeight { get; set; }

    // Relacionamento com PurchaseNotification
    public Guid PurchaseNotificationId { get; set; }
    public PurchaseNotification PurchaseNotification { get; set; }


    // Status da entrega
    public DeliveryStatus Status { get; set; }

}