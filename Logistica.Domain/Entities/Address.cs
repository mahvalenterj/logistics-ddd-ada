using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Entities
{
    public class Address : BaseEntity
    {
        public Guid AddressID { get; set; }
        public string? Street { get; set; } 
        public int Number { get; set; }         
        public string? AddressComplement { get; set; }
        
        public string? City { get; set; }

        public string? Region { get; set; }

        public int PostalCode { get; set; }

    }
}
