using AutoMapper;
using techLogistica.Domain.Entities;


public sealed class CreateProductMapper : Profile
{
    public CreateProductMapper()
    {
        CreateMap<CreateProductRequest, Product>();
        CreateMap<Product, CreateProductResponse>();
    }
}
