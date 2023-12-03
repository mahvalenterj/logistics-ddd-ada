
public class 
    CreateDeliveryPersonResponse
{
    public Guid Id { get; init; }
    public string Message { get; init; } = string.Empty; // Inicializado como string vazia para evitar null
    public DateTime DeliveryDate { get; init; }
    public Guid PurchaseNotificationId { get; init; }
    public Guid ShippingId { get; init; }
    public Guid DeliveryPersonId { get; init; }
}
