using Logistics.Domain.Entities;

namespace Logistics.Domain.Interfaces
{
    public interface IDeliveryRepository
    {
        Task AddDeliveryAsync(Delivery delivery);
        Task<List<Delivery>> GetDeliveriesByRegionAsync(string region);
    }
}
