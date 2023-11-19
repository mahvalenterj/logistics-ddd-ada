using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Interfaces;

public class RecipientRepository : BaseRepository<Recipient>, IRecipientRepository
{
    public RecipientRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<Recipient> GetByIdAsync(Guid recipientId, CancellationToken cancellationToken)
    {
        return await Context.Recipients
            .FirstOrDefaultAsync(x => x.Id == recipientId, cancellationToken);
    }

}