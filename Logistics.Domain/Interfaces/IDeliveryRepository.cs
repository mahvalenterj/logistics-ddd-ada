using Logistics.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Interfaces
{
    public interface IDeliveryRepository
    {
        Task AddDeliveryAsync(Delivery delivery);
        Task<List<Delivery>> GetDeliveriesByRegionAsync(string region);
    }
}
