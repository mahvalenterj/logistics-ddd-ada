using FluentValidation;

public sealed class CreatePolicyValidator : AbstractValidator<CreatePolicyRequest>
{
    public CreatePolicyValidator()
    {
        RuleFor(x => x.AddressRegion);
        RuleFor(x => x.ValueShipping);
    }
}

/*
 * public TypePolicy TypePolicy { get; set; }
    public UserPerfil UserPerfil { get; set; }
    public bool ApplyDiscount { get; set; }
    public double ValueDiscount { get; set; }
    public double ValueCashback { get; set; }
**/