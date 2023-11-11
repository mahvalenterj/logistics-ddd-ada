using Logistics.Domain.Entities;

public interface IProductRepository : IBaseRepository<Product>
{

    Task<Product> GetProductByIdAsync(Guid productId);
    Task AddProductAsync(Product product);

}
