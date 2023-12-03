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
        // Use o m�todo FindAsync para buscar uma entidade por chave prim�ria
        return await Context.Deliveries.FindAsync(new object[] { deliveryId }, cancellationToken);
    }

    public async Task<Delivery> GetInProgressDeliveryByDeliveryPersonId(Guid deliveryPersonId, CancellationToken cancellationToken = default)
    {
        // Adicione a l�gica para obter a entrega em andamento para o entregador espec�fico
        return await Context.Deliveries
            .Where(d => d.DeliveryPersonId == deliveryPersonId && d.Status == DeliveryStatus.OnTheWay)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
