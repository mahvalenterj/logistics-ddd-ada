using AutoMapper;
using MediatR;

public class CreateDeliveryPersonHandler :
       IRequestHandler<CreateDeliveryPersonRequest, CreateDeliveryPersonResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeliveryPersonRepository _deliveryPersonRepository;
    private readonly IMapper _mapper;

    public CreateDeliveryPersonHandler(IUnitOfWork unitOfWork,
        IDeliveryPersonRepository deliveryPersonRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _deliveryPersonRepository = deliveryPersonRepository;
        _mapper = mapper;
    }

    public async Task<CreateDeliveryPersonResponse> Handle(CreateDeliveryPersonRequest request,
        CancellationToken cancellationToken)
    {
        var deliveryPerson = _mapper.Map<DeliveryPerson>(request);

        _deliveryPersonRepository.Create(deliveryPerson);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateDeliveryPersonResponse>(deliveryPerson);
    }
}
