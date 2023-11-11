using AutoMapper;
using Logistics.Domain.Entities;

public class CreatePolicyMapper : Profile
{
    public CreatePolicyMapper()
    {
        CreateMap<CreatePolicyRequest, Policy>();
        CreateMap<Policy, CreatePolicyResponse>();
    }
}