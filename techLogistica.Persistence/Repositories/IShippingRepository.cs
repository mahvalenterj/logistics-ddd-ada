using System;
using techLogistica.Domain.Entities;

namespace techLogistica.Domain.Interfaces;

public interface IShippingRepository : IBaseRepository<Shipping>
{
    Task<Shipping> GetById(Guid id, CancellationToken cancellationToken);
}