using AutoMapper;
using Logistics.Domain.Entities;
using Logistics.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class CreateNotificationHandler : IRequestHandler<CreateNotificationRequest, CreateNotificationResponse>
{
    // unit of work
    private readonly IUnitOfWork _unitOfWork;
    // repository camada de dados
    private readonly IPurchaseNotificationRepository _notificationRepository; // Corrigido o nome do repositório
    // mapper
    private readonly IMapper _mapper;

    public CreateNotificationHandler(IUnitOfWork unitOfWork, IPurchaseNotificationRepository notificationRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _notificationRepository = notificationRepository;
        _mapper = mapper;
    }

    public async Task<CreateNotificationResponse> Handle(CreateNotificationRequest request, CancellationToken cancellationToken)
    {
        // onde de fato vamos mandar as informações para os nossos bds
        var notification = _mapper.Map<PurchaseNotification>(request);

        _notificationRepository.Create(notification);

        // aqui chama o nosso controle transacional
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateNotificationResponse>(notification);
    }
}
