using Logistics.Application.UseCases.GetProduct;
using Logistics.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly GetProductByIdUseCase _getProductByIdUseCase;
        private readonly AddProductUseCase _addProductUseCase;

        public ProductController(GetProductByIdUseCase getProductByIdUseCase, AddProductUseCase addProductUseCase)
        {
            _getProductByIdUseCase = getProductByIdUseCase;
            _addProductUseCase = addProductUseCase;
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetProductById(Guid productId)
        {
            var product = await _getProductByIdUseCase.Execute(productId);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            await _addProductUseCase.Execute(product);

            return CreatedAtAction(nameof(GetProductById), new { productId = product.ProductId }, product);
        }
    }
}

