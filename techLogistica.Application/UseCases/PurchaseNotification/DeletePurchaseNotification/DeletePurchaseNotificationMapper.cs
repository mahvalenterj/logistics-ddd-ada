using AutoMapper;
using techLogistica.Domain.Entities;

public sealed class DeletePurchaseNotificationMapper : Profile
{
    public DeletePurchaseNotificationMapper()
    {
        CreateMap<DeletePurchaseNotificationRequest, PurchaseNotification>();
        CreateMap<PurchaseNotification, DeletePurchaseNotificationResponse>();
    }
}
