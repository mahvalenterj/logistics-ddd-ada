using techLogistica.Domain.Entities;

public interface IProductRepository :IBaseRepository<Product>
{
    Task<Product> GetByIdAsync(Guid productId, CancellationToken cancellationToken);
}