using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using techLogistica.Domain.Entities;

namespace techLogistica.Domain.Interfaces
{
    public interface IDeliveryPersonRepository : IBaseRepository<DeliveryPerson>
    {
        Task<DeliveryPerson> GetByIdAsync(Guid deliveryPersonId, CancellationToken cancellationToken);

    }

}