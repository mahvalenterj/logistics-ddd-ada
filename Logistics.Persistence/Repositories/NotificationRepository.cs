using Logistics.Domain.Entities;
using Logistics.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.Persistence.Repositories
{
    public class PurchaseNotificationRepository : IPurchaseNotificationRepository
    {
        private readonly DbContext _dbContext;

        public PurchaseNotificationRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(PurchaseNotification notification)
        {
            // Lógica para adicionar a notificação ao contexto do banco de dados
            _dbContext.Set<PurchaseNotification>().Add(notification);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<PurchaseNotification>> GetNotificationsByIdAsync(Guid notificationId)
        {
            // Lógica para obter uma lista de notificações pelo ID do contexto do banco de dados
            return await _dbContext.Set<PurchaseNotification>()
                .Where(n => n.Id == notificationId)
                .ToListAsync();
        }
    }
}
