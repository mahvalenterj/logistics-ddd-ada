using Logistics.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.API.Controllers
{
    [ApiController]
    [Route("api/deliveries")]
    public class DeliveryController : ControllerBase
    {
        private readonly IAddRecipientUseCase _addRecipientUseCase;
        private readonly IAddDeliveryUseCase _addDeliveryUseCase;
        private readonly IGetDeliveriesByRegionUseCase _getDeliveriesByRegionUseCase;

        public DeliveryController(IAddRecipientUseCase addRecipientUseCase, IAddDeliveryUseCase addDeliveryUseCase, IGetDeliveriesByRegionUseCase getDeliveriesByRegionUseCase)
        {
            _addRecipientUseCase = addRecipientUseCase;
            _addDeliveryUseCase = addDeliveryUseCase;
            _getDeliveriesByRegionUseCase = getDeliveriesByRegionUseCase;
        }

        [HttpPost("recipient")]
        public async Task<ActionResult> AddRecipient([FromBody] Recipient recipient)
        {
            await _addRecipientUseCase.Execute(recipient);

            return CreatedAtAction(nameof(AddRecipient), recipient);
        }

        [HttpPost]
        public async Task<ActionResult> AddDelivery([FromBody] Delivery delivery)
        {
            await _addDeliveryUseCase.Execute(delivery);

            return CreatedAtAction(nameof(AddDelivery), delivery);
        }

        [HttpGet("region/{region}")]
        public async Task<ActionResult<List<Delivery>>> GetDeliveriesByRegion(string region)
        {
            var deliveries = await _getDeliveriesByRegionUseCase.Execute(region);

            if (deliveries == null || deliveries.Count == 0)
            {
                return NotFound();
            }

            return Ok(deliveries);
        }
    }
}
