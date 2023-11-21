using techLogistica.Domain.Entities;

public sealed record DeletePurchaseNotificationResponse
{
    public Guid Id { get; set; }
    public string Message { get; set; }
    public decimal TotalValue { get; set; }


    public Guid RecipientId { get; set; }
    public Recipient Recipient { get; set; }

 
    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public decimal ProductWeight { get; set; }

    public string RecipientAddress { get; set; }
    public string RecipientZipCode { get; set; }
}
