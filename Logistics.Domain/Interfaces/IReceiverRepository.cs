using Logistics.Domain.Entities;

namespace Logistics.Domain.Interfaces
{
    public interface IReceiverRepository
    {
        Task AddReceiverAsync(Receiver receiver);
    }
}
