using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace techLogistica.Domain.Interfaces
{
    public interface IDeliveryRepository : IBaseRepository<Delivery>
    {
        Task<Delivery> GetByIdAsync(Guid Id, CancellationToken cancellationToken);
        Task<Delivery> GetInProgressDeliveryByDeliveryPersonId(Guid deliveryPersonId, CancellationToken cancellationToken);
    }
}