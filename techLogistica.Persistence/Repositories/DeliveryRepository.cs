using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Interfaces;

public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
{
    public DeliveryRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Delivery> GetByIdAsync(Guid deliveryId, CancellationToken cancellationToken = default)
    {
        // Use o método FindAsync para buscar uma entidade por chave primária
        return await Context.Deliveries.FindAsync(new object[] { deliveryId }, cancellationToken);
    }

    public async Task<Delivery> GetInProgressDeliveryByDeliveryPersonId(Guid deliveryPersonId, CancellationToken cancellationToken = default)
    {
        // Adicione a lógica para obter a entrega em andamento para o entregador específico
        return await Context.Deliveries
            .Where(d => d.DeliveryPersonId == deliveryPersonId && d.Status == DeliveryStatus.OnTheWay)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
