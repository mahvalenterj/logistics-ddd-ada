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
        public Guid PurchaseNotificationId { get; set; }

        public Receiver DataReceiver { get; set; }

        public Product DataProduct { get; set;}
    }

}
