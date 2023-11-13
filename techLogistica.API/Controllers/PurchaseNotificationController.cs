using Microsoft.AspNetCore.Mvc;
using MediatR;

// Nome da Rota
[Route("api/[controller]")]
[ApiController]
public class PurchaseNotificationController : ControllerBase
{
    IMediator _mediator;

    public PurchaseNotificationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePurchaseNotificationRequest request)
    {
        var purchasenotification = await _mediator.Send(request);
        return Ok(purchasenotification);
    }
}