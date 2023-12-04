using System;


namespace techLogistica.Domain.Entities

{
    public class Shipping : BaseEntity
    {
        // Propriedades da classe Shipping

        // CEP de origem (não pode ser mudado)
        public string OriginCep { get; private set; }

        // CEP de destino (vindo da notificação de compra)
        public string DestinationCep { get; set; }

        // Campo de valor calculado
        public decimal ShippingCost { get; private set; }

        // Referência à entrega associada
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }

}


