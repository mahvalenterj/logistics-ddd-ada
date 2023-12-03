
public class CreateDeliveryResponse
{
    public Guid Id { get; init; }
    public string? Message { get; init; }
    public DateTime DeliveryDate { get; init; }
    public Guid PurchaseNotificationId { get; init; }
    public Guid ShippingId { get; init; }
    public Guid DeliveryPersonId { get; init; }
}

