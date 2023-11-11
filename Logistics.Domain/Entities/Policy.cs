using Logistica.Domain.Entities;

namespace Logistics.Domain.Entities
{
    public class Policy : BaseEntity
    {
        public AddressRegion? AddressRegion { get; set; }
        public bool ApplyShipping { get; set; }
        public double ValueShipping { get; set; }
    }
}
