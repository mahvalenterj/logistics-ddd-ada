using AutoMapper;


public sealed class CalculateShippingMapper : Profile
{
    public CalculateShippingMapper()
    {
        CreateMap<CreatePurchaseNotificationRequest, PurchaseNotification>();
        CreateMap<PurchaseNotification, CalculateShippingResponse>();
    }
}
