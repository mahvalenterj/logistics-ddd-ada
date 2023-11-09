using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Application.UseCases.GetProduct
{
    public class GetProductByIdUseCase
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Execute(Guid productId)
        {
            return await _productRepository.GetProductByIdAsync(productId);
        }
    }
}
