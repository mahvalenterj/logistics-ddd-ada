using AutoMapper;
using techLogistica.Domain.Entities;

public sealed class GetAllPurchaseNotificationMapper : Profile
{
    public GetAllPurchaseNotificationMapper()
    {
        CreateMap<PurchaseNotification, GetAllPurchaseNotificationResponse>();
    }
}
