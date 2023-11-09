using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Entities
{
    public sealed class Shipping : BaseEntity
    {
            
            public Guid ReceiverID { get; set; }

            public Guid AddressID { get; set; }

            public double ValueShipping { get; set; }

            

    }
}
