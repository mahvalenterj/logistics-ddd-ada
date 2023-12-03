﻿using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

public class CreateDeliveryPersonHandler :
       IRequestHandler<CreateDeliveryPersonRequest, CreateDeliveryPersonResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeliveryRepository _deliveryRepository;
    private readonly IMapper _mapper;

    public CreateDeliveryPersonHandler(IUnitOfWork unitOfWork,
        IDeliveryRepository deliveryRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _deliveryRepository = deliveryRepository;
        _mapper = mapper;
    }

    public async Task<CreateDeliveryPersonResponse> Handle(CreateDeliveryPersonRequest request,
        CancellationToken cancellationToken)
    {
        var delivery = _mapper.Map<Delivery>(request);

        _deliveryRepository.Create(delivery);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateDeliveryPersonResponse>(delivery);
    }
}
