using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

namespace techLogistica.Application.UseCases.Shipping.CalculateShipping
{

public class CalculateShippingHandler :
       IRequestHandler<CalculateShippingRequest, CalculateShippingResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CalculateShippingHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<CalculateShippingResponse> Handle(CalculateShippingRequest request,
        CancellationToken cancellationToken)
    {
        // Sempre definir o custo do frete como zero (frete grátis)
        decimal shippingCost = 0.00m;

        // Preencher a resposta
        var response = new CalculateShippingResponse
        {
            ShippingCost = shippingCost,
        };

        return response;
    }
}

}
