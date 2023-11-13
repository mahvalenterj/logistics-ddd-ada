using Microsoft.AspNetCore.Mvc;
using MediatR;
using FluentValidation;
using System;
using System.Threading.Tasks;
using System.Threading;

[Route("api/[controller]")]
[ApiController]
public class PurchaseNotificationController : ControllerBase
{
    private readonly IMediator _mediator;

    public PurchaseNotificationController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePurchaseNotificationRequest request)
    {
        try
        {
            var purchaseNotification = await _mediator.Send(request);
            return Ok(purchaseNotification);
        }
        catch (ValidationException ex)
        {
            // Erros de validação
            return BadRequest(new { Errors = ex.Errors });
        }
        catch (Exception ex)
        {
            // Outras exceções
            // Registre a exceção em log se necessário
            return StatusCode(500, "Ocorreu um erro interno no servidor.");
        }
    }
}
