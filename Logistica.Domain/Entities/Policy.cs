using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Entities
{
    public class Policy : BaseEntity
    {
        public AddressRegion AddressRegion { get; set; }
        public bool ApplyShipping { get; set; }
        public double ValueShipping { get; set; }
    }
}
