﻿namespace Learn.Blazor.Net6.Pag.Models.Product;

public class ProductModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public decimal Price { get; set; }

    public ProductModel() { }

    // Moq
    public ProductModel(string title, string description, decimal price, string? imageUrl = null)
    {
        Id = Guid.NewGuid();

        Title = title;
        Description = description;
        Price = price;

        ImageUrl = imageUrl;
    }
}