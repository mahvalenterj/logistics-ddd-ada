
public sealed record CreatePurchaseNotificationResponse
{
    public Guid Id { get; init; }
    public string? Message { get; init; }
    public decimal TotalValue { get; init; }
    public Guid RecipientId { get; init; }
    public Guid ProductId { get; init; }
    public string? ProductName { get; init; }
    public int ProductQuantity { get; init; }
    public decimal ProductWeight { get; init; }
    public string? RecipientAddress { get; init; }
    public string? RecipientZipCode { get; init; }
}
