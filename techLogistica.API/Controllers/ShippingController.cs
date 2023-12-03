/*using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techLogistica.Application.UseCases;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class CalculateShippingController : ControllerBase
{
    private readonly IMediator _mediator;

    public CalculateShippingController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost]
    public async Task<IActionResult> CalculateShipping(CalculateShippingRequest request)
    {
        try
        {
            var calculateShippingResponse = await _mediator.Send(request);

            // Verifica se o frete é grátis e ajusta a resposta
            if (IsFreeShipping(calculateShippingResponse.DestinationCep))
            {
                calculateShippingResponse.ShippingCost = 0.00m;
            }

            return Ok(calculateShippingResponse);
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao calcular frete: {ex.Message}");
        }
    }

    private bool IsFreeShipping(string destinationCep)
    {
        // Lógica para determinar se o frete é grátis com base no CEP de destino
        // Substitua esta lógica pela condição específica do seu negócio
        return destinationCep.StartsWith("01000") || destinationCep.StartsWith("89000");
    }

    // Restante do código para as demais operações (Update, Delete, GetAll) permanece o mesmo
}
*/