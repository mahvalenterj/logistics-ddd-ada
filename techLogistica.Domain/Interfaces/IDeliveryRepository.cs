using System;
using System.Threading;
using System.Threading.Tasks;
using techLogistica.Domain.Entities;


    public interface IDeliveryRepository : IBaseRepository<Delivery>
    {
        Task<Delivery> GetByIdAsync(Guid deliveryId, CancellationToken cancellationToken);
    }
