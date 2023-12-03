using AutoMapper;

public sealed class DeletePurchaseNotificationMapper : Profile
{
    public DeletePurchaseNotificationMapper()
    {
        CreateMap<DeletePurchaseNotificationRequest, PurchaseNotification>();
        CreateMap<PurchaseNotification, DeletePurchaseNotificationResponse>();
    }
}
