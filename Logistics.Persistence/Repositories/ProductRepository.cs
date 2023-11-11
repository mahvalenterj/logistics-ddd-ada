using Logistics.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Logistics.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContext _dbContext;

        public ProductRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetProductByIdAsync(Guid productId)
        {
            return await _dbContext.Products.FindAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
