using Logistics.Domain.Entities;

public sealed record CreateNotificationResponse
{
    public Guid NotificationId { get; set; }
    public string? ReceiverData { get; set; }
    Product? ProductData { get; set; }
    
    //public string Password { get; set; }
}