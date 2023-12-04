using System;
using techLogistica.Domain.Entities;

public class OnTheWayDeliveryResponse
{
    public Guid DeliveryPersonId { get; set; }
    public Guid DeliveryId { get; set; }
    public DeliveryStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
}

