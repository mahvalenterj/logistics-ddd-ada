namespace Logistics.Domain.Entities
{
    public class Delivery
    {
        public Guid DeliveryId { get; set; }
        public Receiver ReceiverData { get; set; }
        public string Region { get; set; }
        public string DeliveryType { get; set; }
        public int Priority { get; set; }
        public int EstimatedDeliveryTime { get; set; }
        public string Dimensions { get; set; }
        // Outras propriedades relacionadas à entrega
    }
}
