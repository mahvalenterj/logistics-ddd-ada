using Logistica.Domain.Entities;

namespace Logistics.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid ProductId { get; set; }
        public string ProductType { get; set; }
        public string ProductData { get; set; }
    }
}
