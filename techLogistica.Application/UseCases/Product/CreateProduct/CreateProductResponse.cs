
public sealed record CreateProductResponse
{
    public string ProductName { get; init; }
    public int ProductQuantity { get; init; }
    public decimal ProductWeight { get; init; }
}
