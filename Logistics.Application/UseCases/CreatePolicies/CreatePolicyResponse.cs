using Logistics.Domain.Entities;


public sealed record CreatePolicyResponse
{
    public Guid Id { get; set; }
    AddressRegion? AddressRegion { get; set; }
    public bool ApplyShipping { get; set; }
    public double ValueShipping { get; set; }
}
