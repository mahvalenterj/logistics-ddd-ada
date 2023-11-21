using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Recipient : BaseEntity
    {
        // Propriedades específicas do destinatário
        public Guid RecipientId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientZipCode { get; set; }

        // Relacionamento com notificações de compra
        public ICollection<PurchaseNotification>? PurchaseNotifications { get; set; }
}


