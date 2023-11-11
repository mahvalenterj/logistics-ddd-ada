using MediatR;
using Logistics.Domain.Entities;


public sealed record CreatePolicyRequest(
    AddressRegion AddressRegion,
    bool ApplyShipping,
    double? ValueShipping
    ) : IRequest<CreatePolicyResponse>;





/*
 * public TypePolicy TypePolicy { get; set; }
    public UserPerfil UserPerfil { get; set; }
    public bool ApplyDiscount { get; set; }
    public double ValueDiscount { get; set; }
    public double ValueCashback { get; set; }
**/