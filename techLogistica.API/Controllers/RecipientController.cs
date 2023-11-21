using Microsoft.AspNetCore.Mvc;
using MediatR;

// Nome da Rota
[Route("api/[controller]")]
[ApiController]
public class RecipientController : ControllerBase
{
    IMediator _mediator;

    public RecipientController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateRecipientRequest request)
    {
        var recipient = await _mediator.Send(request);
        return Ok(recipient);
    }

    /*[HttpPut("{id}")]
    public async Task<ActionResult<UpdatePurchaseNotificationResponse>>
        Update(Guid id, UpdatePurchaseNotificationRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var deleteRequest = new DeletePurchaseNotificationRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
    }
    [HttpGet]
    public async Task<ActionResult<List<GetAllPurchaseNotificationResponse>>> GetAll (CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllPurchaseNotificationRequest(), cancellationToken);
        return Ok(response);    } */
}