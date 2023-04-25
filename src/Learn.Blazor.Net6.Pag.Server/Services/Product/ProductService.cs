﻿using System.Runtime.CompilerServices;
using Learn.Blazor.Net6.Pag.Data.Repositories.Product;
using Learn.Blazor.Net6.Pag.Grpc.Product;
using Learn.Blazor.Net6.Pag.Models.Product;

namespace Learn.Blazor.Net6.Pag.Server.Services.Product;

public class ProductService : IProductService
{
    public int MaxQuantityPerRequest => _repository.MaxQuantityPerRequest;

    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository) =>
        _repository = repository;

    public async Task<IEnumerable<ProductModel>> GetAsync(ProductGetReq request, CancellationToken token)
    {
        var products = await _repository.GetAsync(request.Quantity, request.Offset, 
            token, isTracking: false);
        
        var models = products
            .Select(dto => dto.MapToModel())
            .ToList();
        
        return models;
    }

    public async IAsyncEnumerable<ProductModel> GetAsyncEnumerable(ProductGetReq request, [EnumeratorCancellation] CancellationToken token)
    {
        await foreach (var dto in _repository.GetAsyncEnumerable(request.Quantity, request.Offset, 
                           isTracking: false).WithCancellation(token))
            yield return dto.MapToModel();
    }

    public async Task<int> GetTotalQuantityAsync(CancellationToken token) =>
        await _repository.GetCountAsync(token);
}