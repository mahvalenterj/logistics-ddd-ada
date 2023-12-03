using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techLogistica.Domain.Entities
{
    public class DeliveryPerson : BaseEntity
    {
        // Propriedades específicas do entregador
        public string DeliveryPersonName { get; set; }
        public string DeliveryPersonPhone { get; set; }
        public string DeliveryLicensePlate { get; set; }

        // Relacionamento com entregas
        public ICollection<Delivery>? Deliveries { get; set; }
    }
}
