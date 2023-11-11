using AutoMapper;
using Logistics.Domain.Entities;

public class CreateMapper : Profile
{
    public CreateMapper()
    {
        CreateMap<CreateNotificationRequest, PurchaseNotification>();
        CreateMap<PurchaseNotification, CreateNotificationResponse>();
    }
}