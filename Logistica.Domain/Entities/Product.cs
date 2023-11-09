using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Entities
{
      public class Product : BaseEntity
        {
            public int ReceiverID { get; set; }
            public int ProductID { get; set; }
            public double Price { get; set; }
            public double Weight { get; set; }
            public int Quantity { get; set; }
    

        }
    }

