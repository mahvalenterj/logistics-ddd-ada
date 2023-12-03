using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class DeliveryController : ControllerBase
{
    private readonly IMediator _mediator;

    public DeliveryController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    /*[HttpGet]
    public async Task<ActionResult<IEnumerable<GetAllDeliveriesResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllDeliveriesRequest(), cancellationToken);
        return Ok(response);
    }*/

    /*[HttpGet("status/{status}")]
    public async Task<ActionResult<GetDeliveriesByStatusResponse>> GetByStatus(DeliveryStatus status, CancellationToken cancellationToken)
    {
        var request = new GetDeliveriesByStatusRequest(status);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }*/

    [HttpPost]
    public async Task<IActionResult> Create(CreateDeliveryRequest request)
    {
        var delivery = await _mediator.Send(request);
        return Ok(delivery);
    }

    [HttpPut("{deliveryId}/accept")]
    public async Task<ActionResult<AcceptDeliveryResponse>> AcceptRequest(Guid deliveryId, AcceptDeliveryRequest request, CancellationToken cancellationToken)
    {
        if (deliveryId != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut("{deliveryId}/ontheway")]
    public async Task<ActionResult<OnTheWayDeliveryResponse>> MarkAsOnTheWay(Guid deliveryId, CancellationToken cancellationToken)
    {
        
        var deliveryPersonId = Guid.NewGuid();
        var request = new OnTheWayDeliveryRequest(deliveryId, deliveryPersonId);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut("{deliveryId}/complete")]
    public async Task<ActionResult<CompleteDeliveryResponse>> CompleteRequest(Guid deliveryId, CompleteDeliveryRequest request, CancellationToken cancellationToken)
    {
        if (deliveryId != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
