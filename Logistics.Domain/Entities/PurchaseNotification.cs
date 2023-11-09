using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Entities
{
    public class PurchaseNotification : BaseEntity
    {
        public Guid NotificationId { get; set; }
        public string RecipientData { get; set; }
        public Product ProductData { get; set; }
    }

}
