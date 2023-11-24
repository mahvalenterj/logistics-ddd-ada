
public sealed record CreateRecipientResponse
{
    
    public string RecipientName { get; init; }
    public string? RecipientAddress { get; init; }
    public string? RecipientZipCode { get; init; }
}
