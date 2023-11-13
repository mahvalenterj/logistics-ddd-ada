// quero garantir que a classe de notificação nao possa ser herdada 

using techLogistica.Domain.Entities;

public class PurchaseNotification : BaseEntity
{
    // Properties specific to the purchase notification
    public string Message { get; set; }
    public decimal TotalValue { get; set; }

    // Relationship with Recipient
    public Guid RecipientId { get; set; }
    public Recipient Recipient { get; set; }

    // Relationship with Product
    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    // Properties specific to the Product in the Notification
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public decimal ProductWeight { get; set; }

    // Other properties specific to the Notification
    public string RecipientAddress { get; set; }
    public string RecipientZipCode { get; set; }
}


