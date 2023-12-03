using Microsoft.AspNetCore.Mvc;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class DeliveryPersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public DeliveryPersonController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDeliveryPersonRequest request)
    {
        var deliveryPerson = await _mediator.Send(request);
        return Ok(deliveryPerson);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllDeliveryPersonResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllDeliveryPersonRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var deleteRequest = new DeleteDeliveryPersonRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
    }
}
