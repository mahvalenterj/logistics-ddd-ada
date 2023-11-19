using techLogistica.Domain.Entities;

namespace techLogistica.Domain.Interfaces
{public interface IRecipientRepository : IBaseRepository<Recipient>

    {
        Task<Recipient> GetByIdAsync(Guid recipientId, CancellationToken cancellationToken);
    }
}
