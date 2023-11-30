using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace techLogistica.Domain.Entities
{
    public class Product : BaseEntity
    {
        // Propriedades específicas do produto
        public string? ProductName { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? ProductWeight { get; set; }

        public PurchaseNotification PurchaseNotification { get; set; }

        public Guid PurchaseNotificationId { get; set; }


        // Relacionamento com notificações de compra
        public ICollection<PurchaseNotification> PurchaseNotifications { get; set; }


        }
    }








   

