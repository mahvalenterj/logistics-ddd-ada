﻿using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Entities
{
    public class Region : BaseEntity
    {
        public string NameRegion { get; set; }
        public int PriceShipping { get; set; }
        

    }
}
