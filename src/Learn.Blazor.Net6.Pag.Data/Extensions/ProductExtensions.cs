﻿using Learn.Blazor.Net6.Pag.Data.Entities;
using Learn.Blazor.Net6.Pag.Models.Product;

namespace Learn.Blazor.Net6.Pag.Data.Extensions;

public static class ProductExtensions
{
    public static ProductModel MapToModel(this ProductEntity entity) => new ProductModel
    {
        Id = entity.Id,
        Title = entity.Title,
        Description = entity.Description,
        ImageUrl = entity.ImageUrl,
        Price = entity.Price,
    };

    public static ProductEntity MapToEntity(this ProductModel model) => new ProductEntity
    {
        Id = model.Id,
        Title = model.Title,
        Description = model.Description,
        ImageUrl = model.ImageUrl,
        Price = model.Price,
    };
}