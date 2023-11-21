
public sealed record CreateRecipientResponse
{
    public Guid RecipientId { get; init; }    
    public string RecipientName { get; init; }
    public string? RecipientAddress { get; init; }
    public string? RecipientZipCode { get; init; }
}
