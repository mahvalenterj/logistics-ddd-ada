using System;
using techLogistica.Domain.Entities;
using techLogistica.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Twilio.TwiML.Voice;

namespace techLogistica.Persistence.Repositories;

public class ShippingRepository : BaseRepository<Shipping>, IShippingRepository
{
    public ShippingRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Shipping> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Shippings.FirstOrDefaultAsync(
            m => m.Id.Equals(id), cancellationToken);
    }
}

