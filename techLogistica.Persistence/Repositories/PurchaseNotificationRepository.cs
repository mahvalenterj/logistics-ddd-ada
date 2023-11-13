using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Interfaces;

public class PurchaseNotificationRepository : BaseRepository<PurchaseNotification>, IPurchaseNotificationRepository
{
    public PurchaseNotificationRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<PurchaseNotification> GetByIdAsync(Guid notificationId, CancellationToken cancellationToken)
    {
        return await Context.PurchaseNotifications
            .FirstOrDefaultAsync(x => x.Id == notificationId, cancellationToken);
    }
}
