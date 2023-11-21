using AutoMapper;


public sealed class CreateRecipientMapper : Profile
{
    public CreateRecipientMapper()
    {
        CreateMap<CreateRecipientRequest, Recipient>();
        CreateMap<Recipient, CreateRecipientResponse>();
    }
}
