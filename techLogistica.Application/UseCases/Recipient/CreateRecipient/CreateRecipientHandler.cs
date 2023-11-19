using AutoMapper;
using MediatR;
using techLogistica.Domain.Interfaces;

public class CreateRecipientHandler :
       IRequestHandler<CreateRecipientRequest, CreateRecipientResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRecipientRepository _recipientRepository;
    private readonly IMapper _mapper;

    public CreateRecipientHandler(IUnitOfWork unitOfWork,
        IRecipientRepository recipientRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _recipientRepository = recipientRepository;
        _mapper = mapper;
    }

    public async Task<CreateRecipientResponse> Handle(CreateRecipientRequest request,
        CancellationToken cancellationToken)
    {
        var recipient = _mapper.Map<Recipient>(request);

        _recipientRepository.Create(recipient);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateRecipientResponse>(recipient);
    }
}
