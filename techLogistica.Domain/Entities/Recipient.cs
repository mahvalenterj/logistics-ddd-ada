using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Recipient : BaseEntity
    {
        // Propriedades específicas do destinatário
        
        public Recipient? RecipientName { get; set; }
        public Recipient? RecipientAddress { get; set; }
        public Recipient? RecipientZipCode { get; set; }

        // Relacionamento com notificações de compra
        public ICollection<PurchaseNotification> PurchaseNotifications { get; set; }
}


