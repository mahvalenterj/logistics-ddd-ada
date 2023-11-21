using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Interfaces;

public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
{
    public DeliveryRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<Delivery> GetByIdAsync(Guid deliveryId, CancellationToken cancellationToken)
    {
        return await Context.Deliveries
            .FirstOrDefaultAsync(x => x.Id == deliveryId, cancellationToken);
    }

}