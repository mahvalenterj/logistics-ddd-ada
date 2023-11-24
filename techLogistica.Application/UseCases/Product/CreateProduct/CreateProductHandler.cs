﻿using AutoMapper;
using MediatR;
using techLogistica.Domain.Entities;
using techLogistica.Domain.Interfaces;


public class CreateProductHandler :
       IRequestHandler<CreateProductRequest, CreateProductResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public CreateProductHandler(IUnitOfWork unitOfWork,
        IProductRepository productRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<CreateProductResponse> Handle(CreateProductRequest request,
        CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Product>(request);

        _productRepository.Create(product);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateProductResponse>(product);
    }
}
