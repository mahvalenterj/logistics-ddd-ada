using Microsoft.EntityFrameworkCore;

namespace Logistics.Persistence.Repositories
{
    public class ReceiverRepository : IReceiverRepository
    {
        private readonly DbContext _dbContext;

        public ReceiverRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddRecipientAsync(Receiver receiver)
        {
            _dbContext.Receivers.Add(receiver);
            await _dbContext.SaveChangesAsync();
        }
    }
}
