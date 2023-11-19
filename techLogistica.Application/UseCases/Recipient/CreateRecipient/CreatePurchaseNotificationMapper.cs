using AutoMapper;


public sealed class CreatePurchaseNotificationMapper : Profile
{
    public CreatePurchaseNotificationMapper()
    {
        CreateMap<CreatePurchaseNotificationRequest, PurchaseNotification>();
        CreateMap<PurchaseNotification, CreatePurchaseNotificationResponse>();
    }
}
