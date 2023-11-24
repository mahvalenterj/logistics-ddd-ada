using Microsoft.EntityFrameworkCore;
using techLogistica.Domain.Entities;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<Product> GetByIdAsync(Guid productId, CancellationToken cancellationToken)
    {
        return await Context.Products
            .FirstOrDefaultAsync(x => x.Id == productId, cancellationToken);
    }
}