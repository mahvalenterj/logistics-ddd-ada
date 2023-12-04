using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using techLogistica.Domain.Entities;

public class AcceptDeliveryResponse
{
    public Guid DeliveryPersonId { get; set; }
    public Guid DeliveryId { get; set; }

    public Guid PurchaseNotificationId { get; set; }    
    public DeliveryStatus Status { get; set; }

}

