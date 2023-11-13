using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techLogistica.Domain.Entities
{
    public class Recipient : BaseEntity
    {
        // Propriedades específicas do destinatário
        public string RecipientName { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientZipCode { get; set; }

        // Relacionamento com Notificação de Compra
        public Guid PurchaseNotificationId { get; set; }
        public PurchaseNotification PurchaseNotification { get; set; }
    }
}

