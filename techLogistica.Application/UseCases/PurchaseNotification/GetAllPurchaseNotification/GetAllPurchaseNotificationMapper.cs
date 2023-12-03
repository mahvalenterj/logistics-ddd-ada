using AutoMapper;

public sealed class GetAllPurchaseNotificationMapper : Profile
{
    public GetAllPurchaseNotificationMapper()
    {
        CreateMap<PurchaseNotification, GetAllPurchaseNotificationResponse>();
    }
}
