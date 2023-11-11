using Logistics.Domain.Entities;
using Logistics.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Logistics.Persistence.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly DbContext _dbContext;

        public DeliveryRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddDeliveryAsync(Delivery delivery)
        {
            _dbContext.Deliveries.Add(delivery);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Delivery>> GetDeliveriesByRegionAsync(string region)
        {
            return await _dbContext.Deliveries.Where(d => d.Region == region).ToListAsync();
        }
    }
}
