using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Entities;
using techLogistica.Domain.Interfaces;

public class DeliveryPersonRepository : BaseRepository<DeliveryPerson>, IDeliveryPersonRepository
{
    public DeliveryPersonRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<DeliveryPerson> GetByIdAsync(Guid deliveryPersonId, CancellationToken cancellationToken = default)
    {
        // Use o método FindAsync para buscar uma entidade por chave primária
        return await Context.DeliveryPersons.FindAsync(new object[] { deliveryPersonId }, cancellationToken);
    }
}