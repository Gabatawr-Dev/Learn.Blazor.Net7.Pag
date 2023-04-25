using Learn.Blazor.Net6.Pag.Data.Repositories.Product;
using Learn.Blazor.Net6.Pag.Server.GrpcServices.Product;
using Learn.Blazor.Net6.Pag.Server.Services.Product;

namespace Learn.Blazor.Net6.Pag.Server;

public static partial class Program
{
    private static WebApplicationBuilder AddRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        return builder;
    }

    private static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IProductService, ProductService>();
        return builder;
    }

    private static IEndpointRouteBuilder AddGrpcServices(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGrpcService<ProductGrpcService>().EnableGrpcWeb();
        return endpoints;
    }
}