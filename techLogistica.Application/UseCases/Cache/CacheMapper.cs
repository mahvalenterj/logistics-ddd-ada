using AutoMapper;
using techLogistica.Domain.Entities;

public class CacheMapper : Profile
{
    public CacheMapper()
    {
        CreateMap<CacheRequest, Cache>();
        CreateMap<Cache, CacheResponse>();
    }
}