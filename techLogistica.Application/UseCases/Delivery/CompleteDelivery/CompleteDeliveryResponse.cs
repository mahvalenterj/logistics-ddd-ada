using System;
using techLogistica.Domain.Entities;

public class CompleteDeliveryResponse
{
    public Guid DeliveryPersonId { get; set; }
    public Guid DeliveryId { get; set; }
    public DeliveryStatus Status { get; set; }
    // Pessoa que entregou x Status da entrega
}
